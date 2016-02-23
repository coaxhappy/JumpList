using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Lnk;
using OleCf;

namespace JumpList
{
    public class AutoJumpListFile
    {
        public AppIdInfo AppId { get; }

        public List<AutoDestList> DestList;  
        public int DestListCount { get; }
        public int PinnedDestListCount { get; }

        public int DestListVersion { get; }

        public string SourceFile { get; }

        private readonly OleCfFile _oleContainer;

        public AutoJumpListFile(byte[] rawBytes, string sourceFile)
        {
            SourceFile = sourceFile;

            var appid = sourceFile.Split('.').FirstOrDefault();
            if (appid != null)
            {
                var aid = new AppIdInfo(appid);
            }

            _oleContainer = new OleCfFile(rawBytes, sourceFile);

            DestList = new List<AutoDestList>();

            DestListCount = _oleContainer.DestList.Header.NumberOfEntries;
            PinnedDestListCount = _oleContainer.DestList.Header.NumberOfPinnedEntries;
            DestListVersion = _oleContainer.DestList.Header.Version;
            

            foreach (var entry in _oleContainer.DestList.Entries)
            {
                var dirItem =
                                _oleContainer.DirectoryItems.SingleOrDefault(
                                    t => t.DirectoryName == entry.EntryNumber.ToString("X"));

                var p = _oleContainer.GetPayloadForDirectory(dirItem);

                var dlnk = new LnkFile(p,$"{AppId.AppId} ==> Directory name {entry.EntryNumber}");

                var dl = new AutoDestList(entry,dlnk);

                DestList.Add(dl);
            }

        }

        public void DumpAllLnkFiles(string outDir)
        {
            foreach (var directoryItem in _oleContainer.DirectoryItems)
            {
                if (directoryItem.DirectoryName.ToLowerInvariant() == "root entry" || directoryItem.DirectoryName.ToLowerInvariant() == "destlist")
                {
                    continue;
                }

                var lnkBytes = _oleContainer.GetPayloadForDirectory(directoryItem);

                if (lnkBytes[0] == 0x4c)
                {
                    var fName = $"AppId_{AppId}_DirName_{directoryItem.DirectoryName}.lnk";
                    var outPath = Path.Combine(outDir, fName);

                    File.WriteAllBytes(outPath,lnkBytes);
                }
            }
        }
    }

    public class AppIdInfo
    {
        public string AppId { get; }
        public string Description =>
        GetDescription();

        public AppIdInfo(string appId)
        {
            AppId = appId;
            
        }

        public string GetDescription()
        {
            var desc = "Unknown AppId";

            //do lookup here

            return desc;
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


        public AutoDestList(DestListEntry destEntry, Lnk.LnkFile lnk)
        {
            Hostname = destEntry.Hostname;
            VolumeDroid = destEntry.VolumeDroid;
            VolumeBirthDroid = destEntry.VolumeBirthDroid;
            FileDroid = destEntry.FileDroid;
            FileBirthDroid = destEntry.FileBirthDroid;
            EntryNumber = destEntry.EntryNumber;
            CreatedOn = destEntry.CreationTime;
            LastModified = destEntry.LastMod;
            Pinned = destEntry.PinStatus != -1;
            Path = destEntry.Path;
            MacAddress = destEntry.MacAddress;

            Lnk = lnk;
        }
    }
}
