using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks_1_4
{
    public class HomeTask3_Arrays
    {
        public static void HW3()
        {
            HW3_T0_Is_Number_in_array();
            HW3_T1_Delete_Entered_Number();
            HW3_T2_Max_Min_Average_Value();
            HW3_T3_Average_of_array_elements();
            HW3_T5_Change_odd_elements();
            HW3_T6_Array_Sorting();
            HW3_T9_2_Dimension_Array_Elements_Sum();
        }

        /// <summary>
        /// TASK #0 - Is_Number_in_array
        /// </summary>
        public static void HW3_T0_Is_Number_in_array()
        {
            int[] numbers = { 17, 2, 55, 6, 11, };
            Console.WriteLine("Please enter your number");
            int findNumber = int.Parse(Console.ReadLine());
            bool checkNumber = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (findNumber == numbers[i])
                {
                    checkNumber = true;
                }
            }
            if (checkNumber == true)
            {
                Console.WriteLine("Entered number is in array");
            }
            else
            {
                Console.WriteLine("Entered number is not in array");
            }
        }

        //TASK #1 - DELETE_ENTERED_NUMBER
        public static void HW3_T1_Delete_Entered_Number()
        {
            int[] myArray = { 7, 24, 43, 4, 35 };
            Console.WriteLine("Please enter the number to delete it from array");
            int indexToDelete = Array.IndexOf(myArray, int.Parse(Console.ReadLine()));
            myArray = Delete(myArray, indexToDelete);
            Console.WriteLine(string.Join(" ", myArray));
        }
        public static int[] Delete(int[] myArray, int numberToDelete)
        {
            if (numberToDelete < myArray.Length && numberToDelete >= 0)
            {
                int[] myArray2 = new int[myArray.Length - 1];
                for (int i = 0, j = 0; i < myArray.Length; i++)
                {
                    if (i == numberToDelete) continue;
                    {
                        myArray2[j++] = myArray[i];
                    }
                }
                myArray = myArray2;
            }
            else
            {
                Console.WriteLine("Number is out of array!");
            }
            return myArray;
        }

        //TASK #2 - MAX_MIN_AVERAGE_VALUE
        public static void HW3_T2_Max_Min_Average_Value()
        {
            Console.WriteLine("Enter array length");
            int[] myArray = new int[int.Parse(Console.ReadLine())];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 20);
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Max value of array is " + myArray.Max());
            Console.WriteLine("Min value of array is " + myArray.Min());
            Console.WriteLine("Average value of array is " + myArray.Average());
        }

        //TASK #3 - AVERAGE_OF_ARRAY_ELEMENTS
        public static void HW3_T3_Average_of_array_elements()
        {
            int[] myArray = new int[5];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(1, 50);
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            int[] myArray2 = new int[5];
            Random random2 = new Random();
            for (int i2 = 0; i2 < myArray2.Length; i2++)
            {
                myArray2[i2] = random2.Next(1, 50);
                Console.Write(myArray2[i2] + " ");
            }
            Console.WriteLine();

            double average1 = (double)myArray.Sum() / 5;
            Console.WriteLine("Average of array #1 is " + "{0: 0.00}", average1);
            double average2 = (double)myArray2.Sum() / 5;
            Console.WriteLine("Average of array #2 is " + "{0: 0.00}", average2);

            if (average1 > average2)
            {
                Console.WriteLine("Average of array #1 is bigger then average of array #2");
            }
            else if (average1 < average2)
            {
                Console.WriteLine("Average of array #2 is bigger then average of array #1");
            }
            else
            {
                Console.WriteLine("Average of array #1 is the same like average of array #2");
            }
        }

        //TASK #5 - CHANGE_ODD_ELEMENTS
        public static void HW3_T5_Change_odd_elements()
        {
            int[] myArray = { 7, 24, 43, 4, 35 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 != 0)
                {
                    myArray[i] = 0;
                }
                Console.Write(myArray[i] + " ");
            }
        }

        //TASK #6 - ARRAY_SORTING
        public static void HW3_T6_Array_Sorting()
        {
            string[] myArray = { "Tom", "Bob", "John", "Kate", "Mark", "Amanda", "Yoko", };
            Array.Sort(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();

            // Вместо цикла [for] можно так
            //Console.WriteLine(String.Join(", ", myArray));
        }

        //TASK #9 - 2_DIMENSION_ARRAY_ELEMENTS_SUM
        public static void HW3_T9_2_Dimension_Array_Elements_Sum()
        {
            int[,] myArray = new int[5, 5];
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(1, 50);
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (int i in myArray)
            {
                sum += i;
            }
            Console.WriteLine("Array elements sum = " + sum);
        }
    }
}
