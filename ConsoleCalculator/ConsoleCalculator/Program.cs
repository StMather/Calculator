using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            {
                int first = 0;
                int second = 0;
                String sign = "";
                Console.WriteLine("Welcome to the Calculator");
                Console.WriteLine("Please enter a number!");
                first = GetInt();
                Console.WriteLine("Please enter another number!");
                second = GetInt();
                Console.WriteLine($"You have chose: {first} and {second} what would you like to do with them? +-*/");
                sign = Console.ReadLine();

                Console.Write($"{first}{sign}{second}=");
                Console.WriteLine(DoMath(first, second, sign));
                Console.Write("Run again? Y/N");
                again = RunAgain(Console.ReadLine());
            } while (again);

        }
        public static String DoMath(int A, int B, String signin)
        {
            String mathout = "";
            int final = 0;
            switch (signin)
            {
                case "+":
                    final = A + B;
                    mathout = final.ToString();
                    break;
                case "-":
                    final = A - B;
                    mathout = final.ToString();
                    break;
                case "x:":
                case "*":
                    final = A * B;
                    mathout = final.ToString();
                    break;
                case "/":
                    try
                    {
                        final = A / B;
                        mathout = final.ToString();
                    }
                    catch(DivideByZeroException)
                    {
                        mathout = "Waoh! You cannot devide by 0";
                    }
                    break;
                case "%":
                    final = A % B;
                    mathout = final.ToString();
                    break;
                default:
                    Console.WriteLine("Please use + - * x / %");
                    //Ask again (Recursion??)
                    break;
            }
            return mathout;
            
        }
        public static int GetInt()
        {
            int intOut = 0;
            try
            {
                intOut = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"That is not a number!");
                intOut = GetInt();
                //if A is not a number ask again(recursion?)
            }
            catch(System.OverflowException)
            {
                Console.WriteLine($"Number out of bounds!");
                intOut = GetInt();
            }
            return intOut;
        }
        public static bool RunAgain(String stringIn)
        {
            if(stringIn == "Y" || stringIn =="y")
            {
                return true;
            }
            else if(stringIn == "N" || stringIn == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Instructions not fallowed.");
                return false;
            }
        }
    }
}
/*
Project objectives
Create a console application
Manage a git repository containing a C# console application
Demonstrate 'branch' workflow
Project requirement
Make a minimum of six commits.
Include a .gitignore file that removes the .suo from source control
Follow csharp code conventions
Follow the four outlined steps above. You may choose to do more, like ask for three numbers if you finish the project quickly
Implement a form of branching, i.e. if/else or switch statement
Validate user input and catch an exception. i.e. if you request a number from the user, and they instead type out a word like writing "four," request they resubmit or exit the program gracefully." You may want to review training on exception handling and reach out to the class for additional exception handling information. We will discuss exception handling more next week.
Try to think of additional exception you may catch that could arise from your code.
You may demonstrate objected oriented programming through making additional classes. Additional classes are not a requirement this week.
 */