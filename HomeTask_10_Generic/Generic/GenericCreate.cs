using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10_Generic.Generic
{
    public class Generic<T>
    {
        public T[] myArray;

        public Generic()
        {
            myArray = Array.Empty<T>();
        }

        public Generic(T[] myArray)
        {
            this.myArray = myArray;
        }

        //ADD ELEMENT
        public void AddNewElement(T element)
        {
            T[] arrayOne = new T[myArray.Length + 1];
            for (int i = 0; i < myArray.Length; i++)
            {
                arrayOne[i] = myArray[i];
            }
            arrayOne[myArray.Length] = element;
            myArray = arrayOne;
        }

        //DELETE ELEMENT
        public void DeleteElement(T element)
        {
            int searchElement = -1;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Equals(element))
                {
                    searchElement = i;
                    break;
                }
            }
            if (searchElement > -1)
            {
                T[] arrayTwo = new T[myArray.Length - 1];
                for (int i = 0, j = 0; i < myArray.Length; i++)
                {
                    if (i == searchElement)
                        continue;
                    arrayTwo[j] = myArray[i];
                    j++;
                }
                myArray = arrayTwo;
            }
        }

        //FIND ELEMENT
        public void FindElement(int element)
        {
            try
            {
                T arrayElement = myArray[element];

                if (element > -1 && element < myArray.Length)
                {
                    Console.WriteLine(arrayElement);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}\nElement out of arrays range. Array length is: {myArray.Length - 1} elements");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }

        //ARRAY LENGTH
        public int ArrayLength()
        {
            return myArray.Length;
        }
    }
}
