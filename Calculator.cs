using System;

namespace CalculatorApp
{
    class Calculator
    {
    
        public double Son1 { get; set; }
        public double Son2 { get; set; }
      
        public Calculator(double birinchiSon, double ikkinchiSon)
        {
            Son1 = birinchiSon;
            Son2 = ikkinchiSon;
            Console.WriteLine("Kalkulyator obyekti muvaffaqiyatli yaratildi!");
        }        
        public void Hisobla(string op)
        {
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Natija: {Son1} + {Son2} = {Son1 + Son2}");
                    break;
                case "-":
                    Console.WriteLine($"Natija: {Son1} - {Son2} = {Son1 - Son2}");
                    break;
                case "*":
                    Console.WriteLine($"Natija: {Son1} * {Son2} = {Son1 * Son2}");
                    break;
                case "/":
                    if (Son2 != 0)
                        Console.WriteLine($"Natija: {Son1} / {Son2} = {Son1 / Son2}");
                    else
                        Console.WriteLine("Xato: Nolga bo‘lish mumkin emas, ukajon!");
                    break;
                default:
                    Console.WriteLine("Xato: Bunday amal turi mavjud emas!");
                    break;
            }
        }
    }
}