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

        }

        //3. Temperature Converter
        static void TemperatureConverter()
        {

        }

        //4. Simple Discount Calculator
        static void SimpleDiscountCalculator()
        {

        }

        //5. Grading System
        static void GradingSystem()
        {

        }

        //6. Swap Two Numbers
        static void SwapTwoNumbers()
        {

        }

        //7. Days to Weeks and Days Converter
        static void DaysToWeeksAndDaysConverter()
        {

        }

        //8.  Electricity Bill Calculator
        static void ElectricityBillCalculator()
        {

        }

        //9. Simple Calculator
        static void SimpleCalculator()
        {

        }
    }

}

