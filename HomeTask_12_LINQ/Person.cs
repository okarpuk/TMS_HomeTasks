using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_12_LINQ
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<Person> persons;

        public Person(List<Person> persons)
        {
            this.persons = persons;
        }

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PersonsList()
        {

            var eachPerson = from e in persons
                             select e.FirstName + "\t" + e.MiddleName + "\t" + e.LastName;

            foreach (var item in eachPerson)
            {
                Console.WriteLine(item);
            }
        }

        public void PersonsListSorted()
        {
            var listSorted = persons.OrderByDescending(l => l.LastName);

            foreach (var item in listSorted)
            {
                Console.WriteLine(item.FirstName + "\t" + item?.MiddleName + "\t" + item.LastName);
            }
        }
    }
}
