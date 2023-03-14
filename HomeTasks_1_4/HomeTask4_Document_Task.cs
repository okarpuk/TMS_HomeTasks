using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeTasks_1_4
{
    public static class HomeTask4_Document_Task
    {
        /// <summary>
        /// TASK #5 - 1 "Two first blocks of numbers"
        /// </summary>
        /// 
        public static void HW4_T5_1(string docNumber)
        {
            Console.WriteLine(docNumber);
            Console.WriteLine();
            string[] numbers = docNumber.Split(new char[] { '-' });
            Console.WriteLine(numbers[0] + numbers[2]);
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 2 "Change letters to ***"
        /// </summary>
        public static void HW4_T5_2(string docNumber)
        {
            var myString = new StringBuilder(docNumber);
            myString.Replace("abc", "***");
            myString.Replace("eRt", "***");
            string result = myString.ToString();
            Console.WriteLine(result);
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 3 "Delete numbers"
        /// </summary>
        public static void HW4_T5_3(string docNumber)
        {
            var myString2 = new StringBuilder(docNumber);
            myString2.Remove(0, 5);
            myString2.Replace("-0564-", "/");
            myString2.Replace("-1", "/");
            myString2.Replace("2", "/");
            string result2 = myString2.ToString();
            Console.WriteLine(result2.ToLower());
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 4 "Letters"
        /// </summary>
        public static void HW4_T5_4(string docNumber)
        {
            var myString3 = new StringBuilder(docNumber);
            myString3.Replace("5551-", "letters:");
            myString3.Replace("-0564-", "/");
            myString3.Replace("-1", "/");
            myString3.Replace("2", "/");
            string result3 = myString3.ToString();
            Console.WriteLine(result3.ToUpper());
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 5 "Find ABC/abc" 
        /// </summary>
        public static void HW4_T5_5(string docNumber)
        {
            bool mySearch = Regex.IsMatch(docNumber, "\\babc\\b");
            bool mySearch2 = Regex.IsMatch(docNumber, "\\bABC\\b");
            if (mySearch == true || mySearch2 == true)
            {
                Console.WriteLine("[ABC/abc] founded in the text");
            }
            else
            {
                Console.WriteLine("[ABC/abc] not founded in the text");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 6 "Begins with"
        /// </summary>
        public static void HW4_T5_6(string docNumber)
        {
            if (docNumber.StartsWith("555"))
            {
                Console.WriteLine("Number of document starts with 555");
            }
            else
            {
                Console.WriteLine("Number of document is not start with 555");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// TASK #5 - 7 "Ends with"
        /// </summary>
        public static void HW4_T5_7(string docNumber)
        {
            if (docNumber.EndsWith("1a2b"))
            {
                Console.WriteLine("Number of document ends with 1a2b");
            }
            else
            {
                Console.WriteLine("Number of document is not end with 1a2b");
            }
            Console.WriteLine();
        }
    }
}
