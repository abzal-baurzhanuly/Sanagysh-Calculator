using System;

class Calculator
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("--- Санағыш (Калькулятор) ---");
            Console.WriteLine("1. Қосу");
            Console.WriteLine("2. Азайту");
            Console.WriteLine("3. Көбейту");
            Console.WriteLine("4. Бөлу");
            Console.WriteLine("5. Шығу");
            Console.Write("Әрекетті таңдаңыз: ");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                running = false;
                Console.WriteLine("Бағдарлама аяқталды");
                break;
            }

            Console.Write("Бірінші санды енгізіңіз: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Екінші санды енгізіңіз: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine("Нәтиже: " + result);
                    break;

                case "2":
                    result = num1 - num2;
                    Console.WriteLine("Нәтиже: " + result);
                    break;

                case "3":
                    result = num1 * num2;
                    Console.WriteLine("Нәтиже: " + result);
                    break;

                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Нәтиже: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Қате: нөлге бөлуге болмайды");
                    }
                    break;

                default:
                    Console.WriteLine("Қате таңдау");
                    break;
            }
        }
    }
}
