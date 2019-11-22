using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToRomenNumerals
{
    class DictionaryRomenNumeral
    {
        public Dictionary<int, string> dictionary { get; set; }

        public DictionaryRomenNumeral()
        {
            dictionary.Add(1,"I");
            dictionary.Add(4, "IV");
            dictionary.Add(5, "V");
            dictionary.Add(9, "IX");
            dictionary.Add(10, "X");
            dictionary.Add(40, "XL");
            dictionary.Add(50, "L");
            dictionary.Add(90, "X");
            dictionary.Add(100, "C");
            dictionary.Add(400, "CD");
            dictionary.Add(500, "D");
            dictionary.Add(900, "CM");
            dictionary.Add(1000, "M");
        }

    }
}
