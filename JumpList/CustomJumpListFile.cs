using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpList
{
    public class CustomJumpListFile
    {
        public string SourceFile { get; }

        public CustomJumpListFile(byte[] rawBytes, string sourceFile)
        {
            SourceFile = sourceFile;



        }
    }
}
