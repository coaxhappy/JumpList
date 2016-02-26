using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpList
{
    public class AppIdInfo
    {
        public string AppId { get; }
        public string Description =>
        GetDescription(AppId);

        public override string ToString()
        {
            return $"{AppId} ==> {Description}";

        }

        public AppIdInfo(string appId)
        {
            AppId = appId;
        }

        public static string GetDescription(string appId)
        {
            var desc = "Unknown AppId";

            switch (appId.ToLowerInvariant())
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
}
