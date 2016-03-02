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
               
                case "5c450709f7ae4396":
                    return "Firefox 1.0 / 2.0 / 3.0";


                case "16ec093b8f51508f":
                    return "Opera 8.54 build 7730 / 9.64 build 10487 / 11.50 build 1074";


                case "012dc1ea8e34b5a6":
                    return "Microsoft Paint 6.1";
                case "050620fe75ee0093":
                    return "VMware Player 3.1.4";
                case "10f5a20c21466e85":
                    return "FTP Voyager 15.2.0.17";
                case "1110d9896dceddb3":
                    return "imgSeek 0.8.5";
                case "12dc1ea8e34b5a6":
                    return "Microsoft Paint 6.1";
                case "135df2a440abe9bb":
                    return "SoulSeek 156c";
                case "13eb0e5d9a49eaef":
                    return "Binjet 3.0.2";
                case "1434d6d62d64857d":
                    return "BitLord 1.2.0-66";
                case "1461132e553e2e6c":
                    return "Firefox 6.0";
                case "169b3be0bc43d592":
                    return "FastPictureViewer Professional 1.6 (Build 211)";

                case "17d3eb086439f0d7":
                    return "TrueCrypt 7.0a";
                case "186b5ccada1d986b":
                    return "NewsGrabber 3.0.36";
                case "19ccee0274976da8":
                    return "mIRC 4.72 / 5.61";
                case "1a60b1067913516a":
                    return "Psi 0.14";
                case "1b29f0dc90366bb":
                    return "AIM 5.9.3857";
                case "1b4dd67f29cb1962":
                    return "Windows Explorer Pinned and Recent.";
                case "1bc392b8e104a00e":
                    return "Remote Desktop";
                case "1cf97c38a5881255":
                    return "MediaPortal 1.1.3";
                case "1cffbe973a437c74":
                    return "DSPlayer 0.889 Lite";
                case "1da3c90a72bf5527":
                    return "Safari 4.0.5 (531.22.7) / 5.1 (7534.50)";
                case "1eb796d87c32eff9":
                    return "Firefox 5.0";
                case "20ef367747c22564":
                    return "Bullet Proof FTP 2010.75.0.75";
                case "223bf0f360c6fea5":
                    return "I2P 0.8.8 (restartable)";
                case "226400522157fe8b":
                    return "FileZilla Server 0.9.39 beta";
                case "22cefa022402327d":
                    return "Meca Messenger 5.3.0.52";
                case "23646679aaccfae0":
                    return "Adobe Reader 9.x";
                case "23709f6439b9f03d":
                    return "Hex Editor Neo 5.14";
                case "23f08dab0f6aaf30":
                    return "SoMud 1.3.3";
                case "2417caa1f2a881d4":
                    return "ICQ 7.6 (Build 5617)";
                case "2437d4d14b056114":
                    return "EiskaltDC++ 2.2.3";
                case "2519133d6d830f7e":
                    return "IMatch 3.6.0.113";
                case "2544ff74641b639d":
                    return "WiseFTP 6.1.5";
                case "26717493b25aa6e1":
                    return "Adobe Dreamweaver CS5 (32-bit)";
                case "271e609288e1210a":
                    return "Microsoft Office Access 2010 x86";
                case "27da120d7e75cf1f":
                    return "pbFTPClient 6.1";
                case "27ececd8d89b6767":
                    return "AIM 6.2.14.2 / 6.5.3.12 / 6.9.17.2";
       
                case "28c8b86deab549a1":
                    return "Internet Explorer 8 / 9 / 10 (32-bit)";
                case "290532160612e071":
                    return "WinRAR 2.90 / 3.60 / 4.01";

                case "2a5a615382a84729":
                    return "X-Chat 2 2.8.6-2";
                case "2aa756186e21b320":
                    return "RealTimeQuery 3.2";
                case "2b164f512891ae37":
                    return "NewsWolf NSListGen";
                case "2b53c4ddf69195fc":
                    return "Zune x64";
                case "2d1658d5dc3cbe2d":
                    return "MySpaceIM 1.0.823.0 Beta";
                case "2d61cccb4338dfc8":
                    return "BitTorrent 5.0.0 / 6.0.0 / 7.2.1 (Build 25548)";
                case "2db8e25112ab4453":
                    return "Deluge 1.3.3";
                case "2fa14c7753239e4c":
                    return "Paint.NET 2.72 / 3.5.8.4081.24580";
                case "2ff9dc8fb7e11f39":
                    return "I2P 0.8.8 (no window)";
                case "3094cdb43bf5e9c2":
                    return "Microsoft Office OneNote 2010 x86";
                case "30d23723bdd5d908":
                    return "Digsby (Build 30140) (JL support)";
                case "315e29a36e961336":
                    return "Roboform 7.8";
                case "3168cc975b354a01":
                    return "Slypheed 3.1.2 (Build 1120)";
                case "3198e37206f28dc7":
                    return "CuteFTP 8.3 Professional (Build 8.3.4.0007)";
                case "337ed59af273c758":
                    return "Sticky Notes";
                case "3461e4d1eb393c9c":
                    return "WTW 0.8.18.2852 / 0.8.19.2940";
                case "3594aab44bca414b":
                    return "Windows Photo Viewer";
                case "36801066f71b73c5":
                    return "Binbot 2.0";
                case "36c36598b08891bf":
                    return "Vovox 2.5.3.4250";
                case "36f6bc3efe1d99e0":
                    return "Alt.Binz 0.25.0 (Build 27.09.2007)";
                case "37392221756de927":
                    return "RealPlayer SP 12";
                case "386a2f6aa7967f36":
                    return "EyeBrowse 2.7";
                case "3917dd550d7df9a8":
                    return "Konvertor 4.06 (Build 10)";
                case "3a5148bf2288a434":
                    return "Secure FTP 2.6.1 (Build 20101209.1254)";
                case "3be7b307dfccb58f":
                    return "NiouzeFire 0.8.7.0";
                case "3c0022d9de573095":
                    return "QuteCom 2.2";
                case "3c93a049a30e25e6":
                    return "J. River Media Center 16.0.149";
                case "3cf13d83b0bd3867":
                    return "RevConnect 0.674p (based on DC++)";
                case "3d877ec11607fe4":
                    return "Thunderbird 6.0.2";
                case "3dc02b55e44d6697":
                    return "7-Zip 3.13 / 4.20";
                case "3ed70ef3495535f7":
                    return "Gravity 3.0.4";
                case "3edf100b207e2199":
                    return "digiKam 1.7.0 (KDE 4.4.4)";
                case "3f2cd46691bbee90":
                    return "GOIM 1.1.0";
                case "3f97341a65bac63a":
                    return "Ozum 6.07 (Build 6070)";
                case "4278d3dc044fc88a":
                    return "Gaim 1.5.0";
                case "431a5b43435cc60b":
                    return "Python (.pyc)";
                case "43578521d78096c6":
                    return "Windows Media Player Classic Home Cinema 1.3 (32-bit)";
                case "435a2f986b404eb7":
                    return "SmartFTP 4.0.1214.0";
                case "43886ba3395acdcc":
                    return "Easy Post 3.0";
                case "44a3621b32122d64":
                    return "Microsoft Office Word 2010 x64";
                case "44a398496acc926d":
                    return "Adobe Premiere Pro CS5 (64-bit)";
                case "44a50e6c87bc012":
                    return "Classic FTP Plus 2.15";
                case "454ef7dca3bb16b2":
                    return "Exodus 0.10.0.0";

                case "469e4a7982cea4d4":
                    return "Windows Wordpad";
                case "490c000889535727":
                    return "WinMX 4.9.3.0";
                case "4975d6798a8bdf66":
                    return "7-Zip 4.65 / 9.20";
                case "497b42680f564128":
                    return "Zoner PhotoStudio 13 (Build 7)";
                case "49b5edbd92d8cd58":
                    return "FTP Commander 8.02";
                case "4a49906d074a3ad3":
                    return "Media Go 1.8 (Build 121)";
                case "4a7e4f6a181d3d08":
                    return "broolzShare";
                case "4aa2a5710da3efe0":
                    return "DCSharpHub 2.0.0";
                case "4acae695c73a28c7":
                    return "VLC 0.3.0 / 0.4.6";
                case "4b632cf2ceceac35":
                    return "Robo-FTP Server 3.2.5";
                case "4b6925efc53a3c08":
                    return "BCWipe 5.02.2 Task Manager 3.02.3";
                case "4cdf7858c6673f4b":
                    return "Bullet Proof FTP 1.26";
                case "4d72cfa1d0a67418":
                    return "Newsgroup Image Collector";
                case "4d8bdacf5265a04f":
                    return "The KMPlayer 2.9.4.1434";
                case "4dd48f858b1a6ba7":
                    return "Free Download Manager 3.0 (Build 852)";
                case "4e0ac37db19cba15":
                    return "Xfire 1.138 (Build 44507)";
                case "4f24a7b84a7de5a6":
                    return "Palringo 2.6.3 (r45983)";
                case "4fceec8e021ac978":
                    return "CoffeeCup Free FTP 3.5.0.0";
                case "500b8c1d5302fc9c":
                    return "Python (.pyw)";
                case "50620fe75ee0093":
                    return "VMware Player 3.1.4";
                case "521a29e5d22c13b4":
                    return "Skype 1.4.0.84 / 2.5.0.154 / 3.8.0.139 / 4.2.0.187 / Skype 5.3.0.120 / 5.5.0.115 / 5.5.32.117";
                case "54c803dfc87b52ba":
                    return "Nettalk 6.7.12";
                case "558c5bd9f906860a":
                    return "BearShare Lite 5.2.5.1";
                case "560d789a6a42ad5a":
                    return "DC++ 0.261 / 0.698 / 0.782 (r2402.1)";
                case "59e86071b87ac1c3":
                    return "CuteFTP 8.3 (Build 8.3.4.0007)";
                case "59f56184c796cfd4":
                    return "ACDSee Photo Manager 10 (Build 219)";
                case "5b186fc4a0b40504":
                    return "Dtella 1.2.5 (Purdue network only)";


                case "5d696d521de238c3":
                    return "Chrome 9.0.597.84 / 12.0.742.100 / 13.0.785.215";
                case "5d6f13ed567aa2da":
                    return "Microsoft Office Outlook 2010 x64";
                case "5d7b4175afdcc260":
                    return "Shareaza 2.0.0.0";
                case "5da8f997fd5f9428":
                    return "Internet Explorer x64";
                case "5df4765359170e26":
                    return "Firefox 4.0.1";
                case "5e01ecaf82f7d8e":
                    return "Scour Exchange 0.0.0.228";
                case "5ea2a50c7979fbdc":
                    return "TrustyFiles 3.1.0.22";
                case "5f6e7bc0fb699772":
                    return "Microsoft Office PowerPoint 2010 x64";
                case "6059df4b02360af":
                    return "Kadu 0.10.0 / 0.6.5.5";
                case "6224453d9701a612":
                    return "BinTube 3.7.1.0 (requires VLC 10.5!)";
                case "62bff50b969c2575":
                    return "Quintessential Media Player 5.0 (Build 121)";
                case "62dba7fb39bb0adc":
                    return "Yahoo Messenger 7.5.0.647 / 8.1.0.421 / 9.0.0.2162 / 10.0.0.1270";
                case "65009083bfa6a094":
                    return "(app launched via XPMode)";
                case "65f7dd884b016ab2":
                    return "LimeChat 2.39";
                case "6728dd69a3088f97":
                    return "Windows Command Processor - cmd.exe (64-bit)";
                case "689319b6547cda85":
                    return "emesene 2.11.7";
                case "6a316aa67a46820b":
                    return "Core FTP LE 1.3c (Build 1437) / 2.2 (Build 1689)";
                case "6a8b377d0f5cb666":
                    return "WinSCP 2.3.0 (Build 146)";
                case "6aa18a60024620ae":
                    return "GCN 2.9.1";
                case "6b3a5ce7ad4af9e4":
                    return "IceChat 9 RC2";
                case "6bb54d82fa42128d":
                    return "WinSCP 4.3.4 (Build 1428)";
                case "6bc3383cb68a3e37":
                    return "iTunes 7.6.0.29 / 8.0.0.35";
                case "6e855c85de07bc6a":
                    return "Microsoft Office Excel 2010 x64";
                case "6e9d40a4c63bb562":
                    return "Real Player Alternative 1.25 (Media Player Classic 6.4.8.2 / 6.4.9.0)";
                case "6f647f9488d7a":
                    return "AIM 7.5.11.9 (custom AppID + JL support)";
                case "6fee01bd55a634fe":
                    return "Smuxi 0.8.0.0";
                case "70b52cf73249257":
                    return "Sococo 1.5.0.2274";
                case "714b179e552596df":
                    return "Bullet Proof FTP 2.4.0 (Build 31)";
                case "7192f2de78fd9e96":
                    return "TIFNY 5.0.3";
                case "728008617bc3e34b":
                    return "eM Client 3.0.10206.0";
                case "73c6a317412687c2":
                    return "Google Talk 1.0.0.104";
                case "73ce3745a843c0a4":
                    return "FrostWire 5.1.4";
                case "7494a606a9eef18e":
                    return "Crystal Player 1.98";
                case "74d7f43c1561fc1e":
                    return "Windows Media Player 12 (32-bit)";
                
                case "7526de4a8b5914d9":
                    return "Forte Agent 6.00 (Build 32.1186)";
                case "7593af37134fd767":
                    return "RealPlayer 6.0.6.99 / 7 / 8 / 10.5";
                case "76689ff502a1fd9e":
                    return "Imagine Image and Animation Viewer 1.0.7";
                case "76f6f1bd18c19698":
                    return "aMule 2.2.6";
                case "776beb1fcfc6dfa5":
                    return "Thunderbird 1.0.6 (20050716) / 3.0.2";
                case "777483d3cdac1727":
                    return "Gajim 0.14.4";
                case "780732558f827a42":
                    return "AutoPix 5.3.3";
                case "784182360de0c5b6":
                    return "Kazaa Lite 1.7.1";
                case "7904145af324576e":
                    return "Total Commander 7.56a (Build 16.12.2010)";
                case "792699a1373f1386":
                    return "Piolet 3.1.1";
                case "79370f660ab51725":
                    return "UploadFTP 2.0.1.0";
                case "7937df3c65790919":
                    return "FTP Explorer 10.5.19 (Build 001)";
                case "7a7c60efd66817a2":
                    return "Spotnet 1.7.4";
                case "7b2b4f995b54387d":
                    return "News Reactor 20100224.16";
                case "7cb0735d45243070":
                    return "CDisplay 1.8.1.0";
                case "7e4dca80246863e3":
                    return "Control Panel";
                case "7fd04185af357bd5":
                    return "UltraLeeacher 1.7.0.2969 / 1.8 Beta (Build 3490)";
                case "8172865a9d5185cb":
                    return "Binreader 1.0 (Beta 1)";
                case "817bb211c92fd254":
                    return "GOM Player 2.0.12.3375 / 2.1.28.5039";
                case "8211531a7918b389":
                    return "Newsbin Pro 6.00 (Build 1019) (JL support)";
                case "83b03b46dcd30a0e":
                    return "iTunes 10";
                case "84f066768a22cc4f":
                    return "Adobe Photoshop CS5 (64-bit)";
                case "8628e76fd9020e81":
                    return "Fling File Transfer Plus 2.24";
                case "86781fe8437db23e":
                    return "Messenger Pro 2.66.6.3353";
                case "86b804f7a28a3c17":
                    return "Miranda IM 0.6.8 / 0.7.6 / 0.8.27 / 0.9.9 / 0.9.29";
                case "884fd37e05659f3a":
                    return "VZOchat 6.3.5";
                case "8904a5fd2d98b546":
                    return "IceChat 7.70 20101031";
                case "89b0d939f117f75c":
                    return "Adobe Acrobat 9 Pro Extended (32-bit)";
                case "8a1c1c7c389a5320":
                    return "Safari 3.2.3 (525.29)";
                case "8bd5c6433ca967e9":
                    return "ACDSee Photo Manager 2009 (v11.0 Build 113)";
                case "8c816c711d66a6b5":
                    return "MSN Messenger 6.2.0137 / 7.0.0820";
                case "8deb27dfa31c5c2a":
                    return "CoffeeCup Free FTP 4.4 (Build 1904)";
                case "8eafbd04ec8631ce":
                    return "VMware Workstation 9 x64";
                case "8f852307189803b8":
                    return "Far Manager 2.0.1807";
                case "90e5e8b21d7e7924":
                    return "Winamp 3.0d (Build 488)";
                case "918e0ecb43d17e23":
                    return "Notepad (32-bit)";
                case "92f1d5db021cd876":
                    return "NewsLeecher 4.0 / 5.0 Beta 6";
                case "93b18adf1d948fa3":
                    return "qutIM 0.2";
                case "954ea5f70258b502":
                    return "Windows Script Host - wscript.exe (32-bit)";
                case "9560577fd87cf573":
                    return "LeechFTP 1.3 (Build 207)";
                case "96252daff039437a":
                    return "Lphant 7.0.0.112351";
                case "977a5d147aa093f4":
                    return "Lphant 3.51";
                case "9839aec31243a928":
                    return "Microsoft Office Excel 2010 x86";
                case "989d7545c2b2e7b2":
                    return "IMVU 465.8.0.0";
                case "98b0ef1c84088":
                    return "fulDC 6.78";
                case "99c15cf3e6d52b61":
                    return "mldonkey 3.1.0";
                case "9a3bdae86d5576ee":
                    return "WinSCP 3.2.1 (Build 174) / 3.8.0 (Build 312)";
                case "9ad1ec169bf2da7f":
                    return "FlylinkDC++ r405 (Build 7358)";
                case "9b9cdc69c1c24e2b":
                    return "Notepad (64-bit)";
                case "9c7cc110ff56d1bd":
                    return "Microsoft Office PowerPoint 2010 x86";
                case "9dacebaa9ac8ca4e":
                    return "TLNews Newsreader 2.2.0 (Build 2430)";
                case "9e0b3f677a26bbc4":
                    return "BitKinex 3.2.3";
                case "9f03ae476ad461fa":
                    return "GroupsAloud 1.0";
                case "9f5c7755804b850a":
                    return "Windows Script Host - wscript.exe (64-bit)";
                case "9fda41b86ddcf1db":
                    return "VLC 0.5.3 / 0.8.6i / 0.9.7 / 1.1.11";
                case "a1d19afe5a80f80":
                    return "FileZilla 2.2.32";
                case "a31ec95fdd5f350f":
                    return "BitComet 0.49 / 0.59 / 0.69 / 0.79 / 0.89 / 0.99 / 1.07 / 1.28";
                case "a3e0d98f5653b539":
                    return "Instantbird 1.0 (20110623121653) (JL support)";
                case "a4a5324453625195":
                    return "Microsoft Office Word 2013 x86";
                case "a4def57ee99d77e9":
                    return "Nomad News 1.43";
                case "a581b8002a6eb671":
                    return "WiseFTP 5.5.9";
                case "a5db18f617e28a51":
                    return "ICQ 6.5 (Build 2024)";
                case "a746f9625f7695e8":
                    return "HeXHub 5.07";
                
                case "a777ad264b54abab":
                    return "JetVideo 8.0.2.200 Basic";
                case "a79a7ce3c45d781":
                    return "CuteFTP 7.1 (Build 06.06.2005.1)";
                case "a7bd71699cd38d1c":
                    return "Microsoft Office Word 2010 x86";
                case "a8c43ef36da523b1":
                    return "Microsoft Office Word 2003 Pinned and Recent.";
                case "a8df13a46d66f6b5":
                    return "Kommute (Calypso) 0.24";
                case "aa11f575087b3bdc":
                    return "Unzbin 2.6.8";
                case "ac3a63b839ac9d3a":
                    return "Vuze 4.6.0.4";
                case "ac8920ed05001800":
                    return @"DMDirc 0.6.5 (Profile store: C:\Users\$user\AppData\Roaming\DMDirc\)";
                case "accca100973ef8dc":
                    return "Azureus 2.0.8.4";
                case "ace8715529916d31":
                    return "40tude Dialog 2.0.15.1 (Beta 38)";
                case "adecfb853d77462a":
                    return "Microsoft Office Word 2007 Pinned and Recent.";
                case "ae069d21df1c57df":
                    return "mIRC 6.35 / 7.19";
                case "ae3f2acd395b622e":
                    return "QuickTime Player 6.5.1 / 7.0.3 / 7.5.5 (Build 249.13)";
                case "aedd2de3901a77f4":
                    return "Pidgin 2.0.0 / 2.10.0 / 2.7.3";
                case "b0236d03c0627ac4":
                    return "ICQ 5.1 / ICQLite Build 1068";
                case "b0459de4674aab56":
                    return "Windows Virtual PC - vmwindow.exe (32- and 64-bit)";
                case "b06a975b62567622":
                    return "Windows Live Messenger 8.5.1235.0517 BETA";
                case "b17d3d0c9ca7e29":
                    return "Document ViewerPicasa 3.8.0 (Build 117.43, 0)";
                case "b223c3ffbc0a7a42":
                    return "Bersirc 2.2.14";
                case "b3016b8da2077262":
                    return "eMule 0.50a";
                case "b3965c840bf28ef4":
                    return "AIM 4.8.2616";
                case "b39c5f226977725d":
                    return "ACDSee Pro 8.1.99";
                case "b3f13480c2785ae":
                    return "Paint 6.1 (build 7601: SP1)";
                case "b48ce76eda60b97":
                    return "Shareaza 8.0.0.112300";
                case "b50ee40805bd280f":
                    return "QuickTime Alternative 1.9.5 (Media Player Classic 6.4.9.1)";
                case "b6267f3fcb700b60":
                    return "WiseFTP 4.1.0";
                case "b74736c2bd8cc8a5":
                    return "WinZip";
                case "b7cb1d1c1991accf":
                    return "FlashFXP 4.0.0 (Build 1548)";
                case "b868d9201b866d96":
                    return "Microsoft Lync 4.0.7577.0";
                case "b8c13a5dd8c455a2":
                    return "Titan FTP Server 8.40 (Build 1338)";
                case "b8c29862d9f95832":
                    return "Microsoft Office InfoPath 2010 x86";
                case "b91050d8b077a4e8":
                    return "Windows Media Center x64";
                case "ba132e702c0147ef":
                    return "KCeasy 0.19-rc1";
                case "ba3a45f7fd2583e1":
                    return "Blubster 3.1.1";
                case "baea31eacd87186b":
                    return "BinaryBoy 1.97 (Build 55)";
                case "bc03160ee1a59fc1":
                    return "Foxit PDF Reader 5.4.5";
                case "bc0c37e84e063727":
                    return "Windows Command Processor - cmd.exe (32-bit)";
                case "bcc705f705d8132b":
                    return "Instan-t 5.2 (Build 2824)";
                case "bcd7ba75303acbcf":
                    return "BitLord 1.1";
                case "bd249197a6faeff2":
                    return "Windows Live Messenger 2011";
                case "be4875bb3e0c158f":
                    return "CrossFTP 1.75a";
                case "be71009ff8bb02a2":
                    return "Microsoft Office Outlook x86";
                case "bf483b423ebbd327":
                    return "Binary Vortex 5.0";
                case "bf9ae1f46bd9c491":
                    return "Nimbuzz 2.0.0 (rev 6266)";
                case "bfc1d76f16fa778f":
                    return "Ares (Galaxy) 1.8.4 / 1.9.8 / 2.1.0 / 2.1.7.3041";
                case "bfe841f4d35c92b1":
                    return "QuadSucker/News 5.0";
                case "c01d68e40226892b":
                    return "ClicksAndWhistles 2.7.146";
                case "c02baf50d02056fc":
                    return "FotoVac 1.0";
                case "c04f69101c131440":
                    return "CuteFTP 5.0 (Build 50.6.10.2)";
                case "c2d349a0e756411b":
                    return "Adobe Reader 8.1.2";
                case "c312e260e424ae76":
                    return "Mail.Ru Agent 5.8 (JL support)";
                case "c5236fd5824c9545":
                    return "PLAYXPERT 1.0.140.2822";
                case "c54b96f328bdc28d":
                    return "WiseFTP 7.3.0";
                case "c5c24a503b1727df":
                    return "XnView 1.98.2 Small / 1.98.2 Standard";
                case "c5ef839d8d1c76f4":
                    return "LimeWire 5.2.13";
                case "c634153e7f5fce9c":
                    return "IrfanView 3.10 / 4.30";
                case "c6f7b5bf1b9675e4":
                    return "BitWise IM 1.7.3a";
                case "c71ef2c372d322d7":
                    return "PGP Desktop 10";
                case "c765823d986857ba":
                    return "Adobe Illustrator CS5 (32-bit)";
                case "c7a4093872176c74":
                    return "Paint Shop Pro Pinned and Recent.";
                case "c845f3a6022d647c":
                    return "Another File 2.03 (Build 2/7/2004)";
                case "c8aa3eaee3d4343d":
                    return "Trillian 0.74 / 3.1 / 4.2.0.25 / 5.0.0.35 (JL support)";
                case "c8e4c10e5460b00c":
                    return "iMesh 6.5.0.16898";
                case "c91d08dcfc39a506":
                    return "SM Player 0.6.9 r3447";
                case "c9374251edb4c1a8":
                    return "BitTornado T-0.3.17";
                case "c98ab5ccf25dda79":
                    return "NewsShark 2.0";
                case "c9950c443027c765":
                    return "WinZip 9.0 SR-1 (6224) / 10.0 (6667)";
                case "c99ddde925d26df3":
                    return "Robo-FTP 3.7.9 CronMaker";
                case "ca1eb46544793057":
                    return "RetroShare 0.5.2a (Build 4550)";
                case "ca942805559495e9":
                    return "aMSN 0.98.4";
                case "cb1d97aca3fb7e6b":
                    return "Newz Crawler 1.9.0 (Build 4100)";
                case "cb5250eaef7e3213":
                    return "ApexDC++ 1.4.3.957";
                case "cb984e3bc7faf234":
                    return "NewsRover 17.0 (Rev.0)";
                case "cbbe886eca4bfc2d":
                    return "ExoSee 1.0.0";
                case "cbeb786f0132005d":
                    return "VLC 0.7.2";
                case "cc4b36fbfb69a757":
                    return "gtk-gnutella 0.97";
                case "cc76755e0f925ce6":
                    return "AllPicturez 1.2";
                case "cca6383a507bac64":
                    return "Gadu-Gadu 10.5.2.13164";
                case "ccb36ff8a8c03b4b":
                    return "Azureus 2.5.0.4 / Vuze 3.0.5.0";
                case "cd2acd4089508507":
                    return "AbsoluteTelnet 9.18 Lite";
                case "cd40ead0b1eb15ab":
                    return "NNTPGrab 0.6.2";
                case "cd8cafb0fb6afdab":
                    return "uTorrent 1.7.7 (Build 8179) / 1.8.5 / 2.0 / 2.21 (Build 25113) / 3.0 (Build 25583)";
                case "cdf30b95c55fd785":
                    return "Microsoft Office Excel 2007";
                case "cf6379a9a987366e":
                    return "Digibin 1.31";
                case "cfab0ec14b6f953":
                    return "Express NewsPictures 2.41 (Build 08.05.07.0)";
                case "cfb56c56fa0f0a54":
                    return "Mozilla 0.9.9";
                case "d0261ed6e16b200b":
                    return "News File Grabber 4.6.0.4";
                case "d1fc019238236806":
                    return "Newsgroup Commander Pro 9.05";
                case "d22ad6d9d20e6857":
                    return "ALLPlayer 4.7";
                case "d28ee773b2cea9b2":
                    return "3D-FTP 9.0 build 7";
                case "d33ecf70f0b74a77":
                    return "Picasa 2.2.0 (Build 28.08, 0)";
                case "d3530c5294441522":
                    return "HydraIRC 0.3.165";
                case "d38adec6953449ba":
                    return "Microsoft Office OneNote 2010 x64";
                case "d3c5cf21e86b28af":
                    return "SeaMonkey 2.3.3";
                case "d41746b133d17456":
                    return "Tkabber 0.11.1";
                case "d460280b17628695":
                    return "Java Binary";
                case "d53b52fb65bde78c":
                    return "Android Newsgroup Downloader 6.2";
                case "d5c02fc7afbb3fd4":
                    return "NNTPGrab 0.6.2 Server";
                case "d5c3931caad5f793":
                    return "Adobe Soundbooth CS5 (32-bit)";
                case "d64d36b238c843a3":
                    return "Microsoft Office InfoPath 2010 x86";
                case "d7528034b5bd6f28":
                    return "Windows Live Mail Pinned and Recent.";
                case "d7666c416cba240c":
                    return "NewsMan Pro 3.0.5.2";
                case "d7d647c92cd5d1e6":
                    return "uTalk 2.6.4 r47692";
                case "d7db75db9cdd7c5d":
                    return "Xnews 5.04.25";
                case "d8081f151f4bd8a5":
                    return "CuteFTP 8.3 Lite (Build 8.3.4.0007)";
                case "d838aac097abece7":
                    return "ACDSee Photo Manager 12 (Build 344)";
                case "da7e8de5b8273a0f":
                    return "Yahoo Messenger 5.0.0.1226 / 6.0.0.1922";
                case "dba909a61476ccec":
                    return "NewsWolf 1.41";
                case "dc64de6c91c18300":
                    return "Brosix Communicator 3.1.3 (Build 110719 nid 1)";
                case "dd658a07478b46c2":
                    return "PIRCH98 1.0.1.1190";
                case "de76415e0060ce13":
                    return "Noworyta News Reader 2.9";
                case "dee18f19c7e3a2ec":
                    return "PopNote 5.21";
                case "e0246018261a9ccc":
                    return "qutIM 0.2.80.0";
                case "e0532b20aa26a0c9":
                    return "QQ International 1.1 (2042)";
                case "e0f7a40340179171":
                    return "imule 1.4.5 (rev. 749)";
                case "e107946bb682ce47":
                    return "FileZilla 3.5.1";
                case "e1d47cb031dafb9f":
                    return "BearShare 6.0.0.22717 / 8.1.0.70928 / 10.0.0.112380";
                case "e2a593822e01aed3":
                    return "Adobe Flash CS5 (32-bit)";
                case "e30bbea3e1642660":
                    return "Neebly 1.0.4";
                case "e31a6a8a7506f733":
                    return "Image AXS Pro 4.1";
                case "e36bfc8972e5ab1d":
                    return "XPS Viewer";
                case "e40cb5a291ad1a5b":
                    return "Songbird 1.9.3 (Build 1959)";
                case "e42a8e0f4d9b8dcf":
                    return "Sysax FTP Automation 5.15";
                case "e57cfc995bdc1d98":
                    return "Snagit 11";
                case "e6ea77a1d4553872":
                    return "Gnucleus 1.8.6.0";
                case "e6ee34ac9913c0a9":
                    return "VLC 0.6.2";
                case "e6ef42224b845020":
                    return "ALFTP 5.20.0.4";
                case "e70d383b15687e37":
                    return "Notepad++ 5.6.8 (32-bit)";
                case "e73d9f534ed5618a":
                    return "BitSpirit 1.2.0.228 / 2.0 / 2.6.3.168 / 2.7.2.239 / 2.8.0.072 / 3.1.0.077 / 3.6.0.550";
                case "e76a4ef13fbf2bb1":
                    return "Manolito 3.1.1";
                case "e93dbdcede8623f2":
                    return "Pandion 2.6.106";
                case "e9a39dfba105ea23":
                    return "FastStone Image Viewer 4.6";
                case "ea83017cdd24374d":
                    return "IrfanView Thumbnails";
                case "eab25958dbddbaa4":
                    return "Binary News Reaper 2 (Beta 0.14.7.448)";
                case "eb3300e672136bc7":
                    return "Stream Reactor 1.0 Beta 9 (uses VLC!)";
                case "eb7e629258d326a1":
                    return "WindowWasher 6.6.1.18";
                case "ebd8c95d87f25154":
                    return "Carrier 2.5.5";
                case "ecd21b58c2f65a2f":
                    return "StealthNet 0.8.7.9";
                case "ed49e1e6ccdba2f5":
                    return "GNUnet 0.8.1a";
                case "ed7a5cc3cca8d52a":
                    return "CCleaner 1.32.345 / 1.41.544 / 2.36.1233 / 3.10.1525";
                case "edc786643819316c":
                    return "HoneyView3 #5834";
                case "ee462c3b81abb6f6":
                    return "Adobe Reader X 10.1.0";
                case "efb08d4e11e21ece":
                    return "Paltalk Messenger 10.0 (Build 409)";
                case "f001ea668c0aa916":
                    return "Cabos 0.8.2";
                case "f01b4d95cf55d32a":
                    return "Windows Explorer Windows 8.1.";
                case "f0275e8685d95486":
                    return "Microsoft Office Excel 2013 x86";
                case "f0468ce1ae57883d":
                    return "Adobe Reader 7.1.0";
                case "f09b920bfb781142":
                    return "Camfrog 4.0.47 / 5.5.0 / 6.1 (build 146) (JL support)";
                case "f1a4c04eebef2906":
                    return "[i2p] Robert 0.0.29 Preferences";
                case "f214ca2dd40c59c1":
                    return "FrostWire 4.20.9";
                case "f2cb1c38ab948f58":
                    return "X-Chat 1.8.10 / 2.6.9 / 2.8.9";
                case "f5ac5390b9115fdb":
                    return "Microsoft Office PowerPoint 2007";
                case "f61b65550a84027e":
                    return "iMesh 11.0.0.112351";
                case "f64de962764b9b0f":
                    return "FTPRush 1.1.3 / 2.15";
                case "f674c3a77cfe39d0":
                    return "Winamp 2.95 / 5.1 / 5.621";
                case "f82607a219af2999":
                    return "Cyberduck 4.1.2 (Build 8999)";
                case "f91fd0c57c4fe449":
                    return "ExpanDrive 2.1.0";
                case "f920768fe275f7f4":
                    return "Grabit 1.5.3 Beta (Build 909) / 1.6.2 (Build 940) / 1.7.2 Beta 4 (Build 997)";
                case "f92e607f9de02413":
                    return "RealPlayer 14.0.6.666";
                case "fa496fe13dd62edf":
                    return "KVIrc 3.4.2.1 / 4.0.4";
                case "fa7144034d7d083d":
                    return "Directory Opus 10.0.2.0.4269 (JL tasks supported)";
                case "fb1f39d1f230480a":
                    return "Bopup Messenger 5.6.2.9178 (all languages: en,du,fr,ger,rus,es)";
                case "fb230a9fe81e71a8":
                    return "Yahoo Messenger 11.0.0.2014-us";
                case "fb7ca8059b8f2123":
                    return "ooVoo 3.0.7.21";
                case "fc999f29bc5c3560":
                    return "Robo-FTP 3.7.9";
                case "fe5e840511621941":
                    return "JetAudio 5.1.9.3018 Basic / 6.2.5.8220 Basic / 7.0.0 Basic / 8.0.16.2000 Basic";
                case "ff224628f0e8103c":
                    return "Morpheus 3.0.3.6";
            }

            return desc;
        }
    }
}
