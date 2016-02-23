using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpList
{
    public static class JumpList
    {
        public static AutoJumpListFile LoadAutoJumplist(string autoName)
        {
            var raw = File.ReadAllBytes(autoName);

            return new AutoJumpListFile(raw, autoName);
        }

        public static CustomJumpListFile LoadCustomJumplist(string customName)
        {
            var raw = File.ReadAllBytes(customName);

            return new CustomJumpListFile(raw,customName);

        }
    }
}
