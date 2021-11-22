using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RepetitionLabb1b.Finished
{
    public class FileDataReader: IGetStringReader
    {
        private const string FILEPATH = @"C:\Solutions\ITHS-Lektion3\RepetitionLabb1b\TextFile1.txt";
        public string GetString()
        {
            using (StreamReader sr = new StreamReader(FILEPATH))
            {
                string? line = sr.ReadLine();

                if (line is null) throw new Exception("File was null");

                if (String.IsNullOrEmpty(line)) throw new Exception("First line was empty");

                string? secondLine = sr.ReadLine();
                if (secondLine is not null) throw new Exception("File contained more than one line");
            
                return line;
            }
        }
    }
}
