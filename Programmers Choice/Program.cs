using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers_Choice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
             void Quit()
            {
                Console.WriteLine("Press any number to return to the previous menu, or press 0 to quit.");
                int quit = 0;

                    while (!int.TryParse(Console.ReadLine(), out quit))
                    {
                        Console.WriteLine("The instructions said press any number or 0.");
                    }
                
               
                if (quit == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();

                    
                    Environment.Exit(0);

                }
                Console.Clear();
                
            }
                Console.WriteLine("Welcome to a formula calculator!\n Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            while (true)
            { 
                Console.WriteLine("Please select one of the equations you would like to use.\n");
                Console.WriteLine("1: Simple two number addition.                            2: Simple two number subtraction.\n");
                Console.WriteLine("3: Pythagorean Theorem.                                   4: Circumferance of a Circle.\n");
                Console.WriteLine("5: Calculate MPH to KPH.                                  6: Convert Fahrenheit to Celsius.\n");
                Console.WriteLine("7: Simple two number multiplication.                      8: Simple two number division.\n");
                Console.WriteLine("9: Area of a Circle.                                     10: User's input.\n");
                Console.WriteLine("                      Press 0 to quit the application.            ");  
                int input = 0;
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Select 1 through 10 or 0.");
                }

                Console.Clear();
                
                if(input == 0)
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    
                }
                if (input == 1)
                {
                    Console.Write("Please enter the first number you'd like to add:  ");
                    double add1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Please enter the second number you'd like to add:  ");
                    double add2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine(add1 + " + " + add2 + " = " + (add1 + add2) + "\n");
                    Quit();

                }else if(input == 2)
                {
                    Console.Write("Please enter the first number you'd like to subtract:  ");
                    double sub1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Please enter the second number you'd like to subtract:  ");
                    double sub2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine(sub1 + " - " + sub2 + " = " + (sub1 - sub2) + "\n");
                    Quit();

                }
                else if(input == 3)
                {
                    Console.Write("Please enter variable " + "a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("Please enter variable " + "b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    

                    Console.WriteLine("The answer is: " + (Math.Sqrt((a * a) + (b * b)) + "\n"));
                    Quit();
                    
                }
                else if(input == 4)
                {
                    Console.Write("Please enter the radius: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("The answer is: " + (2 * Math.PI * r) + "\n");
                    Quit();
                }
                else if(input == 5)
                {
                    Console.Write("Please enter MPH: ");
                    double mph = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("The answer is: " + ((mph * 6) / (10) + mph) + " KmH" +"\n");
                    Quit();

                }
                else if(input == 6)
                {
                    Console.Write("Please enter the fahrenheit: ");
                    double far = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("The answer is: " + ((far - 32.0) * (5.0 / 9.0)) + " C" + "\n");
                    Quit();
                }
                else if(input == 7)
                {
                    Console.Write("Enter the first number to be multiplied: ");
                    double mult1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("Enter the second number to be multiplied: ");
                    double mult2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine(mult1 + " * " + mult2 + " = " + (mult1 * mult2) + "\n");
                    Quit();
                }
                else if(input == 8)
                {
                    Console.Write("Enter the first number: ");
                    double div1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("Enter the second number: ");
                    double div2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine(div1 + " / " + div2 + " = " + (div1 / div2) + "\n");
                    Quit();
                }
                else if(input == 9)
                {
                    Console.Write("Enter the radius: ");
                    double rad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.WriteLine("The area is: " + (Math.PI * (rad * rad)) + "\n");
                    Quit();
                }
                else
                {
                    Console.Write("Select the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("Select the next number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    Console.Write("Select an operator: ");
                    string op = Console.ReadLine();
                    Console.WriteLine("");

                    if(op == "+")
                    {
                        Console.WriteLine("The addition of " + num1 + " and " + num2 + " is " + (num1 + num2) + "\n");
                        Quit();
                    }
                    else if( op == "-")
                    {
                        Console.WriteLine("The subtraction of " + num1 + " and " + num2 + " is " + (num1 - num2) + "\n");
                        Quit();
                    }
                    else if(op == "*")
                    {
                        Console.WriteLine("The multiplication of " + num1 + " and " + num2 + " is " + (num1 * num2) + "\n");
                        Quit();
                    }
                    else if(op == "/")
                    {
                        Console.WriteLine("The division of " + num1 + " and " + num2 + " is " + (num1 / num2) + "\n");
                        Quit();
                    }
                }
            }
            

     
        }
    }

    
}
