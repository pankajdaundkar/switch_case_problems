using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_option_num
{
    internal class switch_case_select_char
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A.For English");
            Console.WriteLine("B.For Hindi");
            Console.WriteLine("C.For Marathi");
            Console.WriteLine("select any one option");

            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("you have selected english");
                    break;

                case 'B':
                    Console.WriteLine("you have selected hindi");
                    break;

                case 'C':
                    Console.WriteLine("you have selected marathi");
                    break;
                default:
                    Console.WriteLine("incorrect option");
                    break;

            }


        }
    }
}
