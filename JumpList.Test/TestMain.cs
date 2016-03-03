using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
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
        public static string LocalPath2 = @"C:\Users\e\Desktop\ITA_JumpLists";
        public static string LocalPath3 = @"C:\Users\e\Desktop\MTF";

        private readonly List<string> _allPaths = new List<string>
        {
            //MiscPath,
            //WinXpPath,
            Win10Path,
            //Win2K3Path,
            Win7Path,
            Win80Path,
            Win81Path,
            LocalPath,
            LocalPath2,
            LocalPath3
            //Win2012Path,
            //Win2012R2Path,
        };

        [Test]
        public void MainTest()
        {

          //  var r2 = File.ReadAllBytes(@"C:\Users\e\Desktop\ITA_JumpLists\PC2_Win10\AutomaticDestinations\5f7b5f1e01b83767.automaticDestinations-ms");
           // var aa = new AutomaticDestination(r2, @"C:\Users\e\Desktop\ITA_JumpLists\PC2_Win10\AutomaticDestinations\5f7b5f1e01b83767.automaticDestinations-ms");

            foreach (var allPath in _allPaths)
            {
                foreach (var fname in Directory.GetFiles(allPath, "*.automaticDestinations-ms", SearchOption.AllDirectories))
                {
                    Debug.WriteLine(fname);
                    var raw = File.ReadAllBytes(fname);

                    var a = new AutomaticDestination(raw, fname);

                    a.DestListCount.Should().Be(a.DestListEntries.Count);

                    Debug.WriteLine(a);
                    Debug.WriteLine("-----------------------------------------------------------------");



                }
            }
        }

   //     [Test]
        public void OneOff()
        {
            var raw = File.ReadAllBytes(@"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\19e6043495a5b4da.automaticDestinations-ms");

            var aaaa = new AutomaticDestination(raw, @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\19e6043495a5b4da.automaticDestinations-ms");

            Debug.WriteLine(aaaa);
        }


        [Test]
        public void CustomTests()
        {

//            var raw1 = File.ReadAllBytes(@"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\CustomDestinations\5d696d521de238c3.customDestinations-ms");
//
//            var c1 = new CustomDestination(raw1, @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\CustomDestinations\5d696d521de238c3.customDestinations-ms");
//
//            var outDir = @"C:\Temp\!!!!!!!out";

            


            foreach (var allPath in _allPaths)
            {
                foreach (var fname in Directory.GetFiles(allPath, "*.customDestinations-ms", SearchOption.AllDirectories))
                {
                    var raw = File.ReadAllBytes(fname);

                    try
                    {
                        Debug.WriteLine($"<<<<<< GOING TO PROCESS: {fname}");
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
