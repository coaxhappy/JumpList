using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Lnk;

namespace JumpList.Custom
{
    public class CustomDestination
    {
     
        public string SourceFile { get; }

        public AppIdInfo AppId { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Source: {SourceFile}");
            sb.AppendLine($"AppId: {AppId}");
            sb.AppendLine($"Total entries: {Entries.Count}");

            var entryNum = 0;
            foreach (var entry in Entries)
            {
                sb.AppendLine($"Entry #: {entryNum}");

                if (entry.Name.Length > 0)
                {
                    sb.AppendLine($"   Name: {entry.Name}");
                }

                sb.AppendLine($"   Total lnk count: {entry.LnkFiles.Count}");

                foreach (var lnkFile in entry.LnkFiles)
                {
                    sb.AppendLine($"   {lnkFile}");
                }
                sb.AppendLine();
                entryNum += 1;
            }
            
          

            return sb.ToString();
        }

        private readonly byte[] footerBytes = { 0xAB, 0xFB, 0xBF, 0xBA };
        private readonly byte[] lnkHeaderBytes = { 0x4C, 0x00, 0x00, 0x00, 0x01, 0x14, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46 };
        
      

        public List<Entry> Entries { get; } 

        public CustomDestination(byte[] rawBytes, string sourceFile)
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

            if (rawBytes.Length <= 24)
            {
                throw new Exception("Empty custom destinations jump list");
            }


            Entries = new List<Entry>();

          

            var index = 0;

         

            //first, check for footer offsets. some files have more than one

            var footerOffsets = new List<int>();
            
            while (index < rawBytes.Length)
            {
                var lo = ByteSearch(rawBytes, footerBytes, index);

                if (lo == -1)
                {
                    break;
                }

                footerOffsets.Add(lo);

                index = lo + footerBytes.Length; //add length so we do not hit on it again
            }

           // Debug.WriteLine($"Footer offsets contains {footerOffsets.Count} offsets: {string.Join(", ", footerOffsets)}");

            var byteChunks = new List<byte[]>();

            var chunkStart = 0;
            foreach (var footerOffset in footerOffsets)
            {
                var chunkSize = footerOffset - chunkStart + 4;
                var bytes = new byte[chunkSize];

                Buffer.BlockCopy(rawBytes, chunkStart, bytes, 0, bytes.Length);

                byteChunks.Add(bytes);

                chunkStart += chunkSize;
            }

            
            foreach (var byteChunk in byteChunks)
            {
                var e = new Entry(byteChunk);

                Entries.Add(e);
            }
        }

        public static int ByteSearch(byte[] searchIn, byte[] searchBytes, int start = 0)
        {
            int found = -1;
            bool matched = false;
            //only look at this if we have a populated search array and search bytes with a sensible start
            if (searchIn.Length > 0 && searchBytes.Length > 0 && start <= (searchIn.Length - searchBytes.Length) && searchIn.Length >= searchBytes.Length)
            {
                //iterate through the array to be searched
                for (int i = start; i <= searchIn.Length - searchBytes.Length; i++)
                {
                    //if the start bytes match we will start comparing all other bytes
                    if (searchIn[i] == searchBytes[0])
                    {
                        if (searchIn.Length > 1)
                        {
                            //multiple bytes to be searched we have to compare byte by byte
                            matched = true;
                            for (int y = 1; y <= searchBytes.Length - 1; y++)
                            {
                                if (searchIn[i + y] != searchBytes[y])
                                {
                                    matched = false;
                                    break;
                                }
                            }
                            //everything matched up
                            if (matched)
                            {
                                found = i;
                                break;
                            }

                        }
                        else
                        {
                            //search byte is only one bit nothing else to do
                            found = i;
                            break; //stop the loop
                        }

                    }
                }

            }
            return found;
        }
    }
}
