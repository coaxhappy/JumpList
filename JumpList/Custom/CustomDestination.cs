namespace JumpList.Custom
{
    public class CustomDestination
    {
        public string SourceFile { get; }

        public CustomDestination(byte[] rawBytes, string sourceFile)
        {
            SourceFile = sourceFile;



        }
    }
}
