using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionLabb1b.Finished
{
    public class StringReverser
    {
        private readonly IGetStringReader _stringReader;

        public StringReverser(IGetStringReader stringReader)
        {
            _stringReader = stringReader;
        }

        public string Reverse()
        {
            string stringToReverse = _stringReader.GetString();

            if (stringToReverse is null)
                throw new ArgumentNullException();

            char[] chars = stringToReverse.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
