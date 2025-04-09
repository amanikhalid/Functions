using System;

namespace Functions
{
    internal class Program
    {
        static double[] marks = new double[10];
        static int[] Ages = new int[10];
        static string[] names = new string[10];
        static DateTime[] dates = new DateTime[10];
        static int StudentCounter = 0;

        static void Main(string[] args)
        {
            int choice = 0; //Declare and initialize choice
            while (true)
            {
                try //handle the exception if the user enter invalid input
                {
                    //Menu System
                    Console.Clear();
                    Console.WriteLine("\nSelect a Program:");
                    Console.WriteLine("1. Even or Odd check");
                    Console.WriteLine("2. Largest of Three Numbers");
                    Console.WriteLine("3. Temperature Converter");
                    Console.WriteLine("4. Simple Discount Calculator");
                    Console.WriteLine("5. Grading System");
                    Console.WriteLine("6. Swap Two Numbers");
                    Console.WriteLine("7. Days to Weeks and Days Converter");
                    Console.WriteLine("8. Electricity Bill Calculator");
                    Console.WriteLine("9. Simple Calculator");
                    Console.WriteLine("10. Exit the system");

                    Console.Write("Enter your choice : ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: EvenOdd(); break;
                        case 2: LargestOfThreeNumbers(); break;
                        case 3: TemperatureConverter(); break;
                        case 4: SimpleDiscountCalculator(); break;
                        case 5: GradingSystem(); break;
                        case 6: SwapTwoNumbers(); break;
                        case 7: DaysToWeeksAndDaysConverter(); break;
                        case 8: ElectricityBillCalculator(); break;
                        case 9: SimpleCalculator(); break;
                        case 10: return;

                        default: Console.WriteLine("Invalid Choice! Try again."); break;
                    }
                    Console.WriteLine("Press any key  "); //ask user to press any key to continue
                    Console.ReadLine(); //read the user input

                }
                catch (Exception e)//show exception message if the user enter invalid input
                {
                    Console.WriteLine(e.Message);


                    Console.WriteLine("Invalid Choice! Try again.");
                    Console.WriteLine("Press any key  "); //ask user to press any key to continue
                    Console.ReadLine(); //read the user inputConsole.ReadLine();
                }


            }
        }
        // 1. Even or Odd Check
        static void EvenOdd()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("The number is Even.");
            else
                Console.WriteLine("The number is Odd.");


            Console.WriteLine(" ");
        }

        //2. Largest of Three Numbers
        static void LargestOfThreeNumbers()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int largest = num1;

            if (largest > num2)
            {
                if (largest > num3)
                    Console.WriteLine("The largest number is:"+largest);
            }
            else
            {
                largest = num2;

                if (largest > num3)
                    Console.WriteLine("The largest number is:" + largest);
                else
                    Console.WriteLine("The largest number is:" + num3);

            }

            Console.WriteLine(" ");
        }

        //3. Temperature Converter
        static void TemperatureConverter()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            Console.WriteLine(" ");

        }

        //4. Simple Discount Calculator
        static void SimpleDiscountCalculator()
        {
            Console.Write("Enter the price of the item: ");
            double price = double.Parse(Console.ReadLine());
            double discount = 0;

            double finalPrice;

            if (price >100)
            {
                discount = (price / 100) * 10;
                finalPrice = price - discount;
                Console.WriteLine("Final price is:" + finalPrice);

            }
            else
            {
                Console.WriteLine("Final price is:" + price);

            }

            Console.WriteLine(" ");
        }

        //5. Grading System
        static void GradingSystem()
        {
            Console.Write("Enter student score: ");
            int score = int.Parse(Console.ReadLine());
            char grade;

            if (score >= 90)
                grade = 'A';
            else if (score >= 80)
                grade = 'B';
            else if (score >= 70)
                grade = 'C';
            else if (score >= 60)
                grade = 'D';
            else
                grade = 'F';






            Console.WriteLine("The student's grade is: " + grade);
            Console.WriteLine(" ");

        }

        //6. Swap Two Numbers
        static void SwapTwoNumbers()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After swapping: First Number = " + a + ", Second Number = " + b);
            Console.WriteLine(" ");
        }

        //7. Days to Weeks and Days Converter
        static void DaysToWeeksAndDaysConverter()
        {
            Console.Write("Enter number of days: ");
            int days = int.Parse(Console.ReadLine());

            int weeks = days / 7;
            int remainingDays = days % 7;

            Console.WriteLine(days + " days = " + weeks + " week(s) and " + remainingDays + " day(s)");
            Console.WriteLine(" ");

        }

        //8.  Electricity Bill Calculator
        static void ElectricityBillCalculator()
        {
            float unitNumber, bill;
            Console.WriteLine("Enter number of units : ");
            unitNumber = float.Parse(Console.ReadLine());
            if (unitNumber <= 100)
            {
                bill = unitNumber * 0.5f;
                Console.WriteLine("The bill is : " + bill);
            }
            else if (unitNumber > 100 && unitNumber <= 300)
            {
                bill = unitNumber * 0.75f;
                Console.WriteLine("The bill is : " + bill);
            }
            else
            {
                bill = unitNumber * 1.0f;
                Console.WriteLine("The bill is : " + bill);
            }

           
        }
        //9. Simple Calculator
        static void SimpleCalculator()
        {
            Console.Write("Enter first number: ");
            double FirstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Enter second number: ");
            double SecondNumber = double.Parse(Console.ReadLine());

            double result = 0;

            if (op == '+')
                result = FirstNumber + SecondNumber;
            else if (op == '-')
                result = FirstNumber - SecondNumber;
            else if (op == '*')
                result = FirstNumber * SecondNumber;
            else if (op == '/')
            {
                if (SecondNumber != 0)
                    result = FirstNumber / SecondNumber;
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid operator!");
                return;
            }

            Console.WriteLine("Result: " + result);
            Console.WriteLine(" ");
        }
    }
}

