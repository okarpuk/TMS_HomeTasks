using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_5_Phones_CreditCards
{
    internal class HomeTask5_CreditCard
    {
        public int accountNumber = 9999;
        public double currentSum = 9999;
        public void Refill()
        {
            Console.WriteLine("Please enter your account number");
            int enteredAccNumber = int.Parse(Console.ReadLine());
            if (enteredAccNumber == accountNumber)
            {
                Console.WriteLine("Please enter sum to refill account");
                double enteredSum = double.Parse(Console.ReadLine());
                currentSum = currentSum + enteredSum;
                Console.WriteLine($"Total sum on your account: {currentSum}");
            }
            else
            {
                Console.WriteLine("Incorrect account number");
            }
            Console.WriteLine();
        }
        public void Withdrawal()
        {
            Console.WriteLine("Please enter your account number");
            int enteredAccNumber = int.Parse(Console.ReadLine());
            if (enteredAccNumber == accountNumber)
            {
                Console.WriteLine("Please enter sum to withdrawal");
                double enteredSum = double.Parse(Console.ReadLine());
                currentSum = currentSum - enteredSum;
                Console.WriteLine($"Total sum on your account: {currentSum}");
            }
            else
            {
                Console.WriteLine("Incorrect account number");
            }
            Console.WriteLine();
        }
        public void SumOnAccount()
        {
            Console.WriteLine($"Total sum on account #{accountNumber}: {currentSum}");
        }
    }
}
