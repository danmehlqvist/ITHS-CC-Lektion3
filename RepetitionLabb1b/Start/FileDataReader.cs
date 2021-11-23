namespace RepetitionLabb1b.Start
{
    public class FileDataReader
    {
        private const string FILEPATH = @"C:\Solutions\ITHS-Lektion3\RepetitionLabb1b\TextFile1.txt";

        public string ReadStringFromFile()
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            {
                string? line = sr.ReadLine();

                if (line is null) throw new Exception("File was null");

                if (String.IsNullOrEmpty(line)) throw new Exception("First line was empty");

                string? secondLine = sr.ReadLine();
                if (secondLine is not null) throw new Exception("File contained more than one line");
            
                return ReverseString(line);
            }
        }

        private string ReverseString(string stringToReverse)
        {
            if (stringToReverse is null)
                throw new ArgumentNullException();

            char[] chars = stringToReverse.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
