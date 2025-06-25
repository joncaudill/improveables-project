namespace WordCountApp
{
    public class Utilities
    {
        public static string WordCount(string inputFilePath)
        {
            string fileText = File.ReadAllText(inputFilePath);

            int fileWordcount = fileText.Split(new char[] { ' ', '\n', '\r', '\t' },
            StringSplitOptions.RemoveEmptyEntries).Length;

            return $"# of words: {fileWordcount}";
        }

    }
}