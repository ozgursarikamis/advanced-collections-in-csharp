using System;
using System.Collections.Generic;

namespace Collections.LinkedLists
{
    internal class Program
    {
        private static void Main()
        {
            var person1 = new Person("Person 1", "Sarikamış", null);
            var person2 = new Person("Person 2", "Sarikamış", person1);
            var person3 = new Person("Person 3", "Sarikamış", person2);

            var personList = new List<Person> { person1, person2, person3 };
            var personLinkedList = new LinkedList<Person>(personList);
            IterateLists(personLinkedList);
            Console.ReadLine();
        }

        private static void IterateLists(IEnumerable<Person> linkedList)
        {
            Console.WriteLine();

            foreach (var item in linkedList)
            {
                Console.WriteLine($"\t {item.FirstName}");
            }

            Console.WriteLine();
        }
    }

    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person PrevNode { get; set; }
        public Person NextNode { get; set; }

        public Person(string firstName, string lastName, Person prevNode)
        {
            FirstName = firstName;
            LastName = lastName;
            PrevNode = prevNode;
        }
    }
}
