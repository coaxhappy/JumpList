using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JumpList.Automatic;
using JumpList.Custom;

namespace JumpList
{
    public static class JumpList
    {
        public static AutomaticDestination LoadAutoJumplist(string autoName)
        {
            var raw = File.ReadAllBytes(autoName);

            return new AutomaticDestination(raw, autoName);
        }

        public static CustomDestination LoadCustomJumplist(string customName)
        {
            var raw = File.ReadAllBytes(customName);

            return new CustomDestination(raw,customName);

        }
    }
}
