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
            Persons myFriends = new Persons();

            // create a few friends...
            Person friend1 = new Person { Firstname = "Jussi", Lastname = "Jurkka", SocialSecurityNumber = "010101-01E6" };
            Person friend2 = new Person { Firstname = "Minna", Lastname = "Kuikka", SocialSecurityNumber = "121212-90L6" };
            Person friend3 = new Person { Firstname = "Anna", Lastname = "Liukko", SocialSecurityNumber = "091216-753E8" };

            // add person to collection
            myFriends.AddPerson(friend1);
            myFriends.AddPerson(friend2);
            myFriends.AddPerson(friend3);

            // print collection
            myFriends.PrintCollection();

            // get a person
            Console.WriteLine("\nGet a person from the collection: ");
            Person friend4 = myFriends.GetPerson(1);
            if (friend4 != null)
            {
                Console.WriteLine(friend4.ToString());
            }
            else
            {
                Console.WriteLine("Position doesn't hold a person.");
            }

            // find person with socialsecuritynumber
            string socialSecurityNumber = "020101-01E6";
            Console.WriteLine("\nFind person with SocialSecurityNumber: ");
            Person friend5 = myFriends.FindPerson(socialSecurityNumber);
            if (friend5 != null)
            {
                Console.WriteLine(friend5.ToString());
            }
            else
            {
                Console.WriteLine("No person with such SocialSecurityNumber.");
            }

        }
    }
}
