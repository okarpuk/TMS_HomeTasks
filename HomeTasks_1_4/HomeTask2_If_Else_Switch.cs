using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_1_4
{
    public class HomeTask2_If_Else_Switch
    {
        public static void HW2()
        {
            HW2_T1_Calculator();
            HW2_T2_Number_ranges();
            HW2_T3_Weather_translator();
            HW2_T4_Even_Odd_V1();
            HW2_T5_Even_Odd_V2();
        }

        // TASK #1 - CALCULATOR
        public static void HW2_T1_Calculator()
        {
            Console.WriteLine("Please enter first number");
            double operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter operation");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Addition result = " + (operand1 + operand2));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Subtraction result = " + (operand1 - operand2));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Multiplication result = " + operand1 * operand2);
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Please enter second number");
                        double operand2 = double.Parse(Console.ReadLine());
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Warning! Can't divide by zero!");
                        }
                        else
                        {
                            Console.WriteLine("Division result = " + operand1 / operand2);
                        }
                        break;
                    }
                default:
                    Console.WriteLine("ERROR!!! Operation is not possible!");
                    break;
            }
        }

        // TASK #2 - NUMBER RANGES
        public static void HW2_T2_Number_ranges()
        {
            Console.WriteLine("Please enter your number in [0-100] range");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine("Entered number is in [0-14] range");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine("Entered number is in [15-35] range");
            }
            else if (number >= 36 && number <= 49)
            {
                Console.WriteLine("Entered number is in [36-49] range");
            }
            else if (number >= 36 && number <= 49)
            {
                Console.WriteLine("Entered number is in [50-100] range");
            }
            else
            {
                Console.WriteLine("Entered number is out of [0-100] range");
            }
        }

        // TASK #3 - WEATHER TRANSLATOR
        public static void HW2_T3_Weather_translator()
        {
            Console.WriteLine("Please enter the word about weather on russian to get english translation");
            string word = Console.ReadLine();
            switch (word)
            {
                //1
                case "солнечно":
                    Console.WriteLine("Translation: sunny");
                    break;
                //2
                case "пасмурно":
                    Console.WriteLine("Translation: cloudy");
                    break;
                //3
                case "ветер":
                    Console.WriteLine("Translation: wind");
                    break;
                //4
                case "дождь":
                    Console.WriteLine("Translation: rain");
                    break;
                //5
                case "снег":
                    Console.WriteLine("Translation: snow");
                    break;
                //6
                case "ураган":
                    Console.WriteLine("Translation: hurricane");
                    break;
                //7
                case "температура":
                    Console.WriteLine("Translation: temperature");
                    break;
                //8
                case "давление":
                    Console.WriteLine("Translation: pressure");
                    break;
                //9
                case "туман":
                    Console.WriteLine("Translation: fog");
                    break;
                //10
                case "влажность":
                    Console.WriteLine("Translation: humidity");
                    break;
                default:
                    Console.WriteLine("Unable to translate. This word is not in the dictionary");
                    break;
            }
        }

        // TASK #4 - EVEN_ODD VERSION 1
        public static void HW2_T4_Even_Odd_V1()
        {
            Console.WriteLine("Please enter your number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }

        // TASK #5 - EVEN_ODD VERSION 2
        public static void HW2_T5_Even_Odd_V2()
        {
            Console.WriteLine("Please enter your number");
            int number = int.Parse(Console.ReadLine());
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("Even number");
                    break;
                default:
                    Console.WriteLine("Odd number");
                    break;
            }
        }
    }
}
