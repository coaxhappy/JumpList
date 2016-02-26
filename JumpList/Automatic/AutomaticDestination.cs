using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lnk;
using OleCf;

namespace JumpList.Automatic
{
    public class AutomaticDestination
    {
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
                foreach (var entry in DestList.Entries)
                {
                    var dirItem =
                                    _oleContainer.Directory.SingleOrDefault(
                                        t => string.Equals(t.DirectoryName, entry.EntryNumber.ToString("X"), StringComparison.InvariantCultureIgnoreCase));

                    if (dirItem != null)
                    {
                        var p = _oleContainer.GetPayloadForDirectory(dirItem);

                        var dlnk = new LnkFile(p, $"{sourceFile}_Directory name_{dirItem.DirectoryName:X}");

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

    public class AppIdInfo
    {
        public string AppId { get; }
        public string Description =>
        GetDescription();

        public override string ToString()
        {
            return $"{AppId} ==> {Description}";

        }

        public AppIdInfo(string appId)
        {
            AppId = appId;
        }

        public string GetDescription()
        {
            var desc = "Unknown AppId";

            switch (AppId.ToLowerInvariant())
            {
                case "9fda41b86ddcf1db":
                    return "VLC 0.5.3/0.8.6i/0.9.7/1.1.11/2.2.1";
                case "5d696d521de238c3":
                    return "Chrome 9.0.597.84 / 12.0.742.100 / 13.0.785.215";
                case "cfb56c56fa0f0a54":
                    return "Mozilla 0.9.9";
                case "5c450709f7ae4396":
                    return "Firefox 1.0 / 2.0 / 3.0";
                case "5df4765359170e26":
                    return "Firefox 4.0.1";
                case "1eb796d87c32eff9":
                    return "Firefox 5.0";
                case "1461132e553e2e6c":
                    return "Firefox 6.0";
                case "28c8b86deab549a1":
                    return "Internet Explorer 8 / 9";
                case "16ec093b8f51508f":
                    return "Opera 8.54 build 7730 / 9.64 build 10487 / 11.50 build 1074";
                case "8a1c1c7c389a5320":
                    return "Safari 3.2.3 (525.29)";
                case "1da3c90a72bf5527":
                    return "Safari 4.0.5 (531.22.7) / 5.1 (7534.50)";
            }

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
