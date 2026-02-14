using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- OOP Kalkulyator Dasturiga Xush Kelibsiz ---");

            Console.Write("Birinchi sonni kiriting: ");
            string input1 = Console.ReadLine();

            Console.Write("Ikkinchi sonni kiriting: ");
            string input2 = Console.ReadLine();

            Console.Write("Amalni tanlang (+, -, *, /): ");
            string op = Console.ReadLine();

            
            if (double.TryParse(input1, out double n1) && double.TryParse(input2, out double n2))
            {
                                
                Calculator meningKalkulyatorim = new Calculator(n1, n2);
                
                
                meningKalkulyatorim.Hisobla(op);
            }
            else
            {
                Console.WriteLine("Iltimos, meni qiynamasdan faqat son kiriting!");
            }

            Console.WriteLine("Dastur tugadi. Chiqish uchun istalgan tugmani bosing...");
            Console.ReadKey();
        }
    }
}