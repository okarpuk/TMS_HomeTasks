using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_12_LINQ
{
    public class CreateMethods
    {
        public string[] myArray;
        public List<int> myList;

        public CreateMethods(string[] myArray) => this.myArray = myArray;

        public CreateMethods(List<int> myList) => this.myList = myList;

        public void OneLetter()
        {
            var oneLetter = myArray.FirstOrDefault(o => o.Length == 1, "THERE IS NO ONE LETTER WORD IN THE ARRAY");
            Console.WriteLine($"FIRST WORD WITH ONLY ONE LETTER: {oneLetter}\n");
        }

        public void EeWord()
        {
            var eeWord = myArray.LastOrDefault(e => e.Contains("ee"), "THERE IS NO WORD WITH [ee] IN THE ARRAY");
            Console.WriteLine($"LAST WORD CONTAINS [ee]: {eeWord}\n");
        }

        public string ConditionSearch(int min, int max)
        {
            var conditionSearch = myArray.LastOrDefault(c => c.Length > min && c.Length < max, $"THERE IS NO WORD WITH LENGTH BETWEEN {min} AND {max} IN THE ARRAY");
            return conditionSearch;
        }

        public int UniqueValues()
        {
            var uniqueValues = myArray.Distinct().Count();
            return uniqueValues;
        }

        public void FromFiveElement()
        {
            var fiveElement = myList.Where(f => f.ToString().EndsWith("3") && f >= 5);
            Console.WriteLine("NUMBERS AFTER THE FIFTH ELEMENT WITH [3]:");

            foreach (var item in fiveElement)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public int ShortestWordLength()
        {
            var shortestWordLength = myArray.OrderBy(s => s.Length).FirstOrDefault().Count();
            return shortestWordLength;
        }

        public static void DictionaryToList(Dictionary<string, int> myDictionary)
        {
            List<KeyValuePair<string, int>> myConvert = myDictionary.ToList();

            var myList = from list in myConvert
                         let key = list.Key
                         let value = list.Value
                         select new
                         {
                             Key = value,
                             Value = key
                         };
            Console.WriteLine("DICTIONARY TO LIST:");

            foreach (var newList in myList)
            {
                Console.WriteLine(newList);
            }
        }
    }
}
