using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //محمد مهدی محمد کاظمی
            //تکلیف شماره5
            //پیشرفته 1
            Console.WriteLine("please enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int Factoriel = 1;
            for(int i=1;i<=number;i++)
            {
                Factoriel *= i;
            }
            Console.WriteLine(Factoriel);
            Console.ReadKey();

        }
    }
}
