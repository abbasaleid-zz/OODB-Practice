using System;

namespace OODB_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedOption = 0;
            int optionsCounter = 1;
            
            for (int i=0; i<8; i++)
            {
                Console.WriteLine("Options " + optionsCounter + ": Lab 00 Problem " + (i+1));
                optionsCounter++;
            }

            Console.Write("Select an option: ");
            selectedOption = Convert.ToInt32(Console.ReadLine());

            switch (selectedOption)
            {
                case 1: Lab00Problem01(); break;
                case 2: Lab00Problem02(); break;
                case 3: Lab00Problem03(); break;
                case 4: Lab00Problem04(); break;
                case 5: Lab00Problem05(); break;
                case 6: Lab00Problem06(); break;
                case 7: Lab00Problem07(); break;


                default: Console.WriteLine("Please enter in range value"); break;
            }
        }

        static void Lab00Problem01()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome to KFU, " + userName);
        }

        static void Lab00Problem02()
        {
            Console.Write("Enter the first number: ");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int sNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + (fNumber + sNumber));
            Console.WriteLine("Product: " + (fNumber * sNumber));

        }

        static void Lab00Problem03()
        {
            Console.Write("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");
        }

        static void Lab00Problem04()
        {
            Console.Write("Enter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Monday");
                    break;
                case 3: Console.WriteLine("Tuesday");
                    break;
                case 4: Console.WriteLine("Wednesday");
                    break;
                case 5: Console.WriteLine("Thrusday");
                    break;
                case 6: Console.WriteLine("Friday");
                    break;
                case 7: Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Enter a value within range!");
                    break;
            }

        }

        static void Lab00Problem05()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + (i*num));
            }
        }

        static void Lab00Problem06()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(num + "*" + counter + "=" + (counter * num));
                counter++;
            }
        }
        static void Lab00Problem07()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = RecursiveFact(num);

            Console.WriteLine("The factorial of {0} is: {1}", num, fact);


        }

        static int RecursiveFact(int n)
        {
            if (n == 0 || n == 1) return 1;
            else return n * RecursiveFact(n - 1);
        }


    }
}
