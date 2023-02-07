using System;

namespace AdressBookSystem_Csharp
{
class Program
    {
        public static List<ContactOfPerson> People = new List<ContactOfPerson>();

        public static void Main(string[] args)
        {
            Console.WriteLine("-------------Welcome to Adress Book System---------------");


        ContactOfPerson person = new ContactOfPerson();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address : ");
            person.Adress = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            person.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            person.State = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            person.Email = Console.ReadLine();

            People.Add(person);
        }
    }
}

