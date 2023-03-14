using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5_Phones_CreditCards
{
    public class HomeTask5_Phone
    {
        public int number = 0;
        public string model = "Unknown";
        public int weight = 0;
        public string name = "Unknown";

        // CONSTRUCTORS
        //public HomeTask5_Phone() { number = 12345678; model = "qwerty"; weight = 222; } // 3 parameters
        //public HomeTask5_Phone() { number = 12345678; model = "qwerty"; }               // 2 parameters
        //public HomeTask5_Phone() { }                                                    // no parameters

        // CONSTRUCTOR WITH 2 PARAMETERS FROM 3
        public HomeTask5_Phone(int number, string model) : this(number, model, 5555555)
        {
        }
        public HomeTask5_Phone(int number = 223344, string model = "Note 9S", int weight = 111)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public void Print()
        {
            Console.WriteLine($"Phone number: {number}, Phone model: {model}, Phone weight: {weight}");
        }
        public void receiveCall()
        {
            Console.Write($"Caller: {name} ");
        }
        // METHOD OVERLOAD
        public void receiveCall(string name)
        {
            Console.Write($"Caller: {name} ");
        }
        public void receiveCall(string name, int number)
        {
            Console.Write($"Caller: {name}, Phone number: {number}");
        }
        public int getNumber()
        {
            Console.WriteLine(number);
            return number;
        }
        public void sendMessage()
        {
            Console.WriteLine("Please enter 3 phone numbers to send message");
            string numberToSend1 = Console.ReadLine();
            string numberToSend2 = Console.ReadLine();
            string numberToSend3 = Console.ReadLine();
            Console.WriteLine($"The message will be send to numbers: {numberToSend1}, {numberToSend2}, {numberToSend3}");
        }
    }
}
