using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JumpList.Automatic;
using JumpList.Custom;
using NUnit.Framework;

namespace JumpList.Test
{
    [TestFixture]
    public class TestMain
    {
        public static string BasePath = @"..\..\TestFiles";
        public static string Win10Path = Path.Combine(BasePath, "Win10");
        public static string Win2K3Path = Path.Combine(BasePath, "Win2k3");
        public static string Win7Path = Path.Combine(BasePath, "Win7");
        public static string Win80Path = Path.Combine(BasePath, "Win80");
        public static string Win81Path = Path.Combine(BasePath, "Win81");
        public static string Win2012Path = Path.Combine(BasePath, "Win2012");
        public static string Win2012R2Path = Path.Combine(BasePath, "Win2012R2");

        // A bunch of good jump lists that I don't want to share =)
        public static string LocalPath = @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent";

        private readonly List<string> _allPaths = new List<string>
        {
            //MiscPath,
            //WinXpPath,
            Win10Path,
            //Win2K3Path,
            Win7Path,
            Win80Path,
            Win81Path,
            LocalPath
            //Win2012Path,
            //Win2012R2Path,
        };

      //  [Test]
        public void MainTest()
        {
            foreach (var allPath in _allPaths)
            {
                foreach (var fname in Directory.GetFiles(allPath, "*.automaticDestinations-ms",SearchOption.AllDirectories))
                {
                    Debug.WriteLine(fname);
                    var raw = File.ReadAllBytes(fname);

                    var a = new AutomaticDestination(raw, fname);

                    Debug.WriteLine(a.AppId);

//                    if (o.DestList != null)
//                    {
//                        Debug.WriteLine(
//                            $"\r\nDestLists. Total entries: {o.DestList.Entries.Count}, Header entry count: {o.DestList.Header.NumberOfEntries}");
//                        foreach (var destListEntry in o.DestList.Entries)
//                        {
//                            Debug.WriteLine(destListEntry);
//
//                            var dlnk =
//                                o.DirectoryItems.SingleOrDefault(
//                                    t => t.DirectoryName == destListEntry.EntryNumber.ToString("X"));
//
//                            if (dlnk != null)
//                            {
//                                Debug.WriteLine($"Found directory entry: {dlnk}");
//
//                                var dlnkB = o.GetPayloadForDirectory(dlnk);
//
//                                if (dlnkB[0] == 0x4c)
//                                {
//                                    Debug.WriteLine("Ya, its a lnk file\r\n");
//                                }
//                                else
//                                {
//                                    Debug.WriteLine("Nooooo");
//                                }
//                            }
//                        }
//                    }

                }
            }
        }


        [Test]
        public void CustomTests()
        {

            var raw1 = File.ReadAllBytes(@"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\CustomDestinations\5d696d521de238c3.customDestinations-ms");

            var c1 = new CustomDestination(raw1, @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\CustomDestinations\5d696d521de238c3.customDestinations-ms");

            var outDir = @"C:\Temp\!!!!!!!out";

            

//
//            return;

            foreach (var allPath in _allPaths)
            {
                foreach (var fname in Directory.GetFiles(allPath, "*.customDestinations-ms", SearchOption.AllDirectories))
                {
                    var raw = File.ReadAllBytes(fname);

                    try
                    {
                        var c = new CustomDestination(raw, fname);

                        Debug.WriteLine(c);
                        Debug.WriteLine("-----------<<<<>>>>-----------------");
                        
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Empty custom") == false)
                        {
                            throw;
                        }
                        
                    }


                    

                }
            }
        }
    }
}
