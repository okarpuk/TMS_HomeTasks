using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_10_Generic.Generic
{
    internal class GenericExecute
    {
        public static void MyGeneric()
        {
            Generic<string> myArray = new Generic<string>();
            myArray.AddNewElement("1stElement");
            myArray.AddNewElement("2ndElement");
            myArray.AddNewElement("3rdElement");
            myArray.AddNewElement("4thElement");
            myArray.AddNewElement("5thElement");
            Console.WriteLine(myArray.ArrayLength());
            myArray.DeleteElement("3rdElement");
            Console.WriteLine(myArray.ArrayLength());
            myArray.FindElement(2);
            myArray.FindElement(9);
        }
    }
}
