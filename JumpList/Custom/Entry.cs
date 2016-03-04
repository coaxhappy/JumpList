using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lnk;

namespace JumpList.Custom
{
    public class Entry
    {
        private readonly byte[] footerBytes = {0xAB, 0xFB, 0xBF, 0xBA};

        private readonly byte[] lnkHeaderBytes =
        {
            0x4C, 0x00, 0x00, 0x00, 0x01, 0x14, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00,
            0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46
        };

        public Entry(byte[] rawBytes)
        {
            LnkFiles = new List<LnkFile>();

            Unknown0 = BitConverter.ToInt32(rawBytes, 0);
            Rank = BitConverter.ToSingle(rawBytes, 4);
            Unknown2 = BitConverter.ToInt32(rawBytes, 8);
            HeaderType = BitConverter.ToInt32(rawBytes, 12);

            Name = string.Empty;
            if (HeaderType == 0)
            {
                var nameLen = BitConverter.ToInt16(rawBytes, 16);
                Name = Encoding.Unicode.GetString(rawBytes, 18, nameLen*2).Split('\0').First();
            }

            var lnkOffsets = new List<int>();
            var index = 0;

            var footerPos = CustomDestination.ByteSearch(rawBytes, footerBytes, index);

            while (index < rawBytes.Length)
            {
                var lo = CustomDestination.ByteSearch(rawBytes, lnkHeaderBytes, index);

                if (lo == -1)
                {
                    break;
                }

                lnkOffsets.Add(lo);

                index = lo + 1; //add length so we do not hit on it again
            }

            //  Debug.WriteLine($"Link offsets contains {lnkOffsets.Count} offsets: {string.Join(", ", lnkOffsets)}");

            //  Debug.WriteLine($"Footer pos: {footerPos}");

            var counter = 0;
            var max = lnkOffsets.Count - 1;
            foreach (var lnkOffset in lnkOffsets)
            {
                var start = 0;
                var end = 0;
                if (counter == max)
                {
                    //last one, so we need to use footerpos
                    start = lnkOffset;
                    end = footerPos;
                }
                else
                {
                    start = lnkOffset;
                    end = lnkOffsets[counter + 1];
                }

                var bytes = new byte[end - start];

                Buffer.BlockCopy(rawBytes, start, bytes, 0, bytes.Length);

//                var outPath = @"C:\Temp\!!!!!!!out";
//                var outName = Path.Combine(outPath, $"Offset_0x{lnkOffset:X}.lnk");
//
//                File.WriteAllBytes(outName,bytes);

                var l = new LnkFile(bytes, $"Offset_0x{lnkOffset:X}.lnk");

                LnkFiles.Add(l);

                counter += 1;
            }
        }

        public string Name { get; }
        public int Unknown0 { get; }
        public float Rank { get; }
        public int Unknown2 { get; }
        public int HeaderType { get; }

        public List<LnkFile> LnkFiles { get; }


        public override string ToString()
        {
            var sb = new StringBuilder();


            sb.AppendLine($"unknown0: {Unknown0}");
            sb.AppendLine($"Rank: {Rank:F4}");
            sb.AppendLine($"unknown2: {Unknown2}");
            sb.AppendLine($"HeaderType: {HeaderType}");
            if (Name.Length > 0)
            {
                sb.AppendLine($"Name: {Name}");
            }

            return sb.ToString();
        }
    }
}