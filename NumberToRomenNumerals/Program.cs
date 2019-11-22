using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToRomenNumerals
{
    class Program
    {
        public static Dictionary<int, string> dictionary = new Dictionary<int, string>();
        public static string romenNumeral = null;
        static void Main(string[] args)
        {
            dictionary.Add(1, "I");
            dictionary.Add(4, "IV");
            dictionary.Add(5, "V");
            dictionary.Add(9, "IX");
            dictionary.Add(10, "X");
            dictionary.Add(40, "XL");
            dictionary.Add(50, "L");
            dictionary.Add(90, "XC");
            dictionary.Add(100, "C");
            dictionary.Add(400, "CD");
            dictionary.Add(500, "D");
            dictionary.Add(900, "CM");
            dictionary.Add(1000, "M");
            while (true)
            {
                Console.Write("Enter your number : ");
                int value = Convert.ToInt16(Console.ReadLine());
                var liste = dictionary.Keys.Reverse();
                foreach (var key in liste)
                {
                    come:
                    if (key <= value)
                    {
                        int residual = value - key;
                        romenNumeral += dictionary[key];
                        value = residual;
                        if (value >= key)
                            goto come;
                        if (residual == 0)
                            break;
                    }
                }
                
                Console.WriteLine("Roma Rakamı : " + romenNumeral);
                Console.ReadKey();
                romenNumeral = null;
            }

        }

        public static void method(List<int> liste, int value)
        {

        }
    }
}
