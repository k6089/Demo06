using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from Persons
            Persons myFriens = new Persons();

            // create a friends...
            Person person1 = new Person { Firstname = "Jussi", Lastname = "Jurkka", SocialSevurityNumber = "010101-016E" };
            Person person2 = new Person { Firstname = "Minna", Lastname = "Husso", SocialSevurityNumber = "020202-012R" };
            Person person3 = new Person { Firstname = "Ankka", Lastname = "Sorsa", SocialSevurityNumber = "030303-013T" };
            Person person7 = new Person { Firstname = "Ankka", Lastname = "Sorsa", SocialSevurityNumber = "030303-013T" };

            // add persons to collection
            myFriens.AddPerson(person1);
            myFriens.AddPerson(person2);
            myFriens.AddPerson(person3);

            // print collection
            myFriens.PrintCollection();

            // get one person
            Console.WriteLine("Get one person from collection:");
            Person person4 = myFriens.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }else
            {
                Console.WriteLine("Cannot find person in that postition...");
            }

            // find person with sotu
            string socialSecurityNumber = "010101-01E6";
            Console.WriteLine("Find person with sotu : " + socialSecurityNumber);
            Person person5 = myFriens.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }else
            {
                Console.WriteLine("Not found...");
            }

        }
    }
}
