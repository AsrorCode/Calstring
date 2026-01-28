using System;

class Program
{
    static void Main()
    {
        // 1-sonni olish
        Console.Write("Birinchi sonni kiriting: ");
        string input1 = Console.ReadLine();
        double number1;

        // 2-sonni olish
        Console.Write("Ikkinchi sonni kiriting: ");
        string input2 = Console.ReadLine();
        double number2;

        // Operatorni olish
        Console.Write("Operator (+, -, *, /) kiriting: ");
        string op = Console.ReadLine();

        // Sonlarni tekshirish
        if (double.TryParse(input1, out number1) && double.TryParse(input2, out number2))
        {
            // If-Else bilan hisoblash
            if (op == "+")
            {
                Console.WriteLine("Natija: " + (number1 + number2));
            }
            else if (op == "-")
            {
                Console.WriteLine("Natija: " + (number1 - number2));
            }
            else if (op == "*")
            {
                Console.WriteLine("Natija: " + (number1 * number2));
            }
            else if (op == "/")
            {
                if (number2 != 0)
                    Console.WriteLine("Natija: " + (number1 / number2));
                else
                    Console.WriteLine("Xato: 0 ga bo‘lish mumkin emas!");
            }
            else
            {
                Console.WriteLine("Xato: noto‘g‘ri operator kiritildi!");
            }
        }
        else
        {
            Console.WriteLine("Xato son kiritildi!");
        }
    }
}
