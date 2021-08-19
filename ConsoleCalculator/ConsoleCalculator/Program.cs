using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;
            String sign = "";
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("Please enter a number!");
            try
            {
                first = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"That is not a number!");
                //if A is not a number ask again(recursion?)
            }
            try
            {
                second = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"That is not a number!");
                //if B is not a number ask again(recursion?)
            }
            Console.WriteLine($"You have chose: {first} and {second} what would you like to do with them? +-*/");
            sign = Console.ReadLine();

            Console.WriteLine(Program.doMath(first, second, sign));

           
            //do math (switch)and print
        }
        public String doMath(int A, int B, String signin)
        {
            String mathout = "";
            switch (signin)
            {
                case "+":
                    //do math +
                    break;
                case "-":
                    //do math -
                    break;
                case "x:":
                case "*":
                    //do math *
                    break;
                case "/":
                    //do math /
                    break;
                case "%":
                    //do math %
                    break;
                default:
                    Console.WriteLine("Please use + - * x / %");
                    //Ask again (Recursion??)
                    break;
            }
            return mathout;
            
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