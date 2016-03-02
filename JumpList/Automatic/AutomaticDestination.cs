using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using Lnk;
using OleCf;

namespace JumpList.Automatic
{
    public class AutomaticDestination
    {
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($">>Source: {SourceFile}");
            sb.AppendLine($"    AppId: {AppId}");
            sb.AppendLine($"    DestList entries Expected: {DestListCount}, Actual: {DestListEntries.Count}");


            foreach (var entry in DestListEntries)
            {
                sb.AppendLine($"Entry #: {entry.EntryNumber}, Path: {entry.Path}");
                sb.AppendLine($"Created: {entry.CreatedOn}, Modified: {entry.LastModified}");
                sb.AppendLine($"Has lnk: {entry.Lnk != null}");
                sb.AppendLine($"Hostname: {entry.Hostname}, MAC Address: {entry.MacAddress}");

                
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public AppIdInfo AppId { get; }

        public int DestListCount { get; }
        public int PinnedDestListCount { get; }

        public int DestListVersion { get; }

        public string SourceFile { get; }

        private DestList DestList { get; }

        public List<AutoDestList> DestListEntries { get; }

        private readonly OleCfFile _oleContainer;

        public AutomaticDestination(byte[] rawBytes, string sourceFile)
        {
            SourceFile = sourceFile;

            var appid = Path.GetFileName(sourceFile).Split('.').FirstOrDefault();
            if (appid != null)
            {
                var aid = new AppIdInfo(appid);
                AppId = aid;
            }
            else
            {
                AppId = new AppIdInfo("Unable to determine AppId");
            }

            _oleContainer = new OleCfFile(rawBytes, sourceFile);

            var destList = _oleContainer.Directory.SingleOrDefault(t => t.DirectoryName.ToLowerInvariant() == "destlist");
            if (destList != null && destList.DirectorySize > 0)
            {
                var destBytes = _oleContainer.GetPayloadForDirectory(destList);

                DestList = new DestList(destBytes);
            }

            

            DestListEntries = new List<AutoDestList>();

            if (DestList != null)
            {
                DestListCount = DestList.Header.NumberOfEntries;
                DestListVersion = DestList.Header.Version;

                foreach (var entry in DestList.Entries)
                {
                    var dirItem =
                                    _oleContainer.Directory.SingleOrDefault(
                                        t => string.Equals(t.DirectoryName, entry.EntryNumber.ToString("X"), StringComparison.InvariantCultureIgnoreCase));

                    if (dirItem != null)
                    {
                        var p = _oleContainer.GetPayloadForDirectory(dirItem);

                        var sfn = $"{sourceFile}_Directory name_{dirItem.DirectoryName:X}";
                        
//                        if (dirItem.DirectoryName == "1fe")
//                        {
//                            Debug.WriteLine(sfn);
//                            File.WriteAllBytes(@"C:\temp\1fe.bin", p);
//                        }


                        var dlnk = new LnkFile(p, sfn);

                        var dle = new AutoDestList(entry, dlnk);

                        DestListEntries.Add(dle);
                    }
                    else
                    {
                        var dleNull = new AutoDestList(entry, null);

                        DestListEntries.Add(dleNull); 
                    }
                }
            }

        }

        public void DumpAllLnkFiles(string outDir)
        {
            foreach (var directoryItem in _oleContainer.Directory)
            {
                if (directoryItem.DirectoryName.ToLowerInvariant() == "root entry" || directoryItem.DirectoryName.ToLowerInvariant() == "destlist")
                {
                    continue;
                }

                var lnkBytes = _oleContainer.GetPayloadForDirectory(directoryItem);

                if (lnkBytes[0] != 0x4c)
                {
                    //this isn't a lnk file since it doesn't start with 0x4c, so continue
                    continue;
                }
                var fName = $"AppId_{AppId}_DirName_{directoryItem.DirectoryName}.lnk";
                var outPath = Path.Combine(outDir, fName);

                File.WriteAllBytes(outPath,lnkBytes);
            }
        }
    }

    

    public class AutoDestList
    {
        public string Hostname { get; }
        public Guid VolumeDroid { get; }
        public Guid VolumeBirthDroid { get; }
        public Guid FileDroid { get; }
        public Guid FileBirthDroid { get; }
        public int EntryNumber { get; }
        public DateTimeOffset CreatedOn { get; }
        public DateTimeOffset LastModified { get; }
        public bool Pinned { get; }
        public string Path { get; }
        public string MacAddress { get; }

        public Lnk.LnkFile Lnk { get; }


        public AutoDestList(DestListEntry destEntry, LnkFile lnk)
        {
            Hostname = destEntry.Hostname;
            VolumeDroid = destEntry.VolumeDroid;
            VolumeBirthDroid = destEntry.VolumeBirthDroid;
            FileDroid = destEntry.FileDroid;
            FileBirthDroid = destEntry.FileBirthDroid;
            EntryNumber = destEntry.EntryNumber;
            CreatedOn = destEntry.CreationTime;
            LastModified = destEntry.LastModified;
            Pinned = destEntry.PinStatus != -1;
            Path = destEntry.Path;
            MacAddress = destEntry.MacAddress;

            Lnk = lnk;
        }
    }
}
