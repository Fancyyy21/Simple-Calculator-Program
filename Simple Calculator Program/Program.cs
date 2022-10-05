using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;

            int result;

            string answer;

            Console.WriteLine("============== Hello, Welcome to the Simple Calculator Progmram ==============");
            Console.WriteLine("");
            Console.WriteLine("Masukkan Angka Pertama");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan Angka Kedua");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operasi Apa Yang Ingin Dilakukan?");
            Console.WriteLine("Ketik + untuk penambahan, - untuk pengurangan, * untuk perkalian, dan / untuk pembagian");

            answer = Console.ReadLine();

            if (answer == "+")
            {
                result = num1 + num2;
            }
            else if (answer == "-")
            {
                result=num1 - num2;
            }
            else if (answer == "*")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("Hasilnya adalah " + result);
            Console.WriteLine("Thank You For Using Our Apps");

                Console.ReadKey();
        }
    }
}
