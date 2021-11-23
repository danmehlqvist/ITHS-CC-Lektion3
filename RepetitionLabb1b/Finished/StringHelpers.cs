using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionLabb1b.Finished
{
    public class StringHelpers
    {
        public string Reverse(string stringToReverse)
        {
            if (stringToReverse is null)
                throw new ArgumentNullException();

            char[] chars = stringToReverse.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
