using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_option_num
{
    internal class switch_case_days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sunday");
            Console.WriteLine("2.Monday");
            Console.WriteLine("3.Tuesday");
            Console.WriteLine("4.Wensday");
            Console.WriteLine("5.Thuseday");
            Console.WriteLine("6.Friday");
            Console.WriteLine("7.saturday");
            Console.WriteLine("select any one");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Day is Sunday");
                    break;

                    case 2:
                    Console.WriteLine("Day is Monday");
                    break;

                    case 3:
                    Console.WriteLine("Day ia Tuseday");
                    break;

                    case 4:
                    Console.WriteLine("Day is Wensday");
                    break;

                    case 5:
                    Console.WriteLine("Day is Thusday");
                    break;

                    case 6:
                    Console.WriteLine("Day is Friday");
                    break;

                    case 7:
                    Console.WriteLine("Day ia Satrurday");
                    break;

                    default: Console.WriteLine("invalid option");
                    break;


           
            }
        }
    }
}
