namespace HomeTask_12_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "mouse", "w", "pioneer", "copybook", "1", "cat", "lamp", "c", "lamp", "keyboard", "display", "3", "volunteer", "u", "device", "3 cats", "cord", "f", "musketeer", "pad" };
            CreateMethods myArray_Methods = new CreateMethods(myArray);

            List<int> myList = new List<int>() { 456, 223, 89, 1, 33, 248, 531, 777, 8, 675, 32, 9, 5467, 3434, 9653 };
            CreateMethods myListMethods = new CreateMethods(myList);

            Dictionary<string, int> myDictionary = new Dictionary<string, int>()
            {
                {"Belarus", 375 },
                {"USA", 1 },
                {"Germany", 49 },
                {"Italy", 38 },
                {"Poland", 48 },
            };

            var persons = new List<Person>()
            {
                new Person("Axel", "Rudi", "Pell"),
                new Person("James", "Hetfield"),
                new Person("Carlos", "Santana"),
                new Person("Ronnie", "James", "Dio"),
                new Person("Robert", "Allen", "Zimmerman"),
                new Person("Bruce", "Dickinson"),
            };
            Person listOfUsers = new Person(persons);

            myArray_Methods.OneLetter();
            myArray_Methods.EeWord();
            Console.WriteLine($"THE LAST WORD WITH LENGTH BETWEEN MIN AND MAX IN THE ARRAY: {myArray_Methods.ConditionSearch(5, 10)}\n");
            Console.WriteLine($"UNIQUE VALUES COUNT: {myArray_Methods.UniqueValues()}\n");
            Console.WriteLine($"SHORTEST WORD LENGTH: {myArray_Methods.ShortestWordLength()}\n");
            myListMethods.FromFiveElement();
            CreateMethods.DictionaryToList(myDictionary);
            Console.WriteLine($"\nPERSONS LIST:");
            listOfUsers.PersonsList();
            Console.WriteLine($"\nSORTED PERSONS LIST:");
            listOfUsers.PersonsListSorted();
        }
    }
}