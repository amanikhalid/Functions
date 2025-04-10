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
                        case 1:


                            Console.Write("Enter a number: ");
                            int num = int.Parse(Console.ReadLine());
                            string result = EvenOdd(num);
                            printValue(result);

                            
                            
                            break;
                        case 2:
                            Console.Write("Enter first number: ");
                            int num1 = int.Parse(Console.ReadLine());

                            Console.Write("Enter second number: ");
                            int num2 = int.Parse(Console.ReadLine());

                            Console.Write("Enter third number: ");
                            int num3 = int.Parse(Console.ReadLine());
                            int result2 = LargestOfThreeNumbers(num1, num2, num3);
                            printValue(result2.ToString());
                            ; break;

                        case 3:
                            Console.Write("Enter temperature in Celsius: ");
                            double celsius = double.Parse(Console.ReadLine()); ; break;
                            double result3 = TemperatureConverter(celsius);
                            printValue(result3.ToString());


                        case 4:
                            Console.Write("Enter the price of the item: ");
                            double price = double.Parse(Console.ReadLine());
                            double finalPrice = SimpleDiscountCalculator(price);
                            printValue(finalPrice.ToString());

                            ; break;
                        case 5:
                            Console.Write("Enter student score: ");
                            int score = int.Parse(Console.ReadLine());
                            char grade = GradingSystem(score);
                            printValue(grade.ToString());
                            break;

                        case 6:
                            Console.Write("Enter first number: ");
                            int a = int.Parse(Console.ReadLine());

                            Console.Write("Enter second number: ");
                            int b = int.Parse(Console.ReadLine());
                            SwapTwoNumbers(a, b);
                            
                            ; break;

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

        // function print 

        public static void printValue(string input)
        {
            Console.WriteLine(" The result of this operation is : "+ input);
        }


        // 1. Even or Odd Check
        public static string EvenOdd(int num)
        {
           

            if (num % 2 == 0)
                return "The number is Even.";
            else
                return "The number is Odd.";


            Console.WriteLine(" ");
        }

        //2. Largest of Three Numbers
       public static int LargestOfThreeNumbers(int num1, int num2, int num3)
        {
           
            int largest = num1;

            if (num2 > largest)
            largest = num2;
            if (num3 > largest)
                largest = num3;

            
                    return largest;
           
        }

        //3. Temperature Converter
       public static double TemperatureConverter(double celsius)
        {
           

            return (celsius * 9 / 5) + 32;
  

        }

        //4. Simple Discount Calculator
        public static double SimpleDiscountCalculator(double price)
        {

            double discount = 0;
            

            if (price >100)
            {
                discount = (price / 100) * 10;
               

            }
            double finalPrice = price - discount;
            return finalPrice;

            
        }

        //5. Grading System
        public static char GradingSystem(int score)
        {
           
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

            return grade;

        }

        //6. Swap Two Numbers
       public static void SwapTwoNumbers(int a, int b)
        {


            int c = a;

            
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

