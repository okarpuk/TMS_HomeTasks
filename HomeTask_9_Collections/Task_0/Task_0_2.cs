using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_9_Collections.Task_0
{
    internal class Task_0_2
    {
        public static void codesList()
        {
            Console.WriteLine("\nPHONE CODES:");
            var phoneCodes = new Dictionary<int, string>()
            {
                { 1, "USA"},
                { 20, "Egypt"},
                { 32, "Belgium"},
                { 53, "Cuba"},
                { 61, "Australia"},
                { 82, "Korea"},
                { 90, "Turkey"},
                { 375, "Belarus"},
                { 502, "Guatemala"},
                { 995, "Georgia"}
            };
            foreach (var countryCode in phoneCodes)
            {
                Console.WriteLine($"Phone code: {countryCode.Key}\tCountry: {countryCode.Value}");
            }
        }
    }
}
