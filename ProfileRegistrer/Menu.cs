using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileRegistrer
{
    internal class Menu
    {
        public static void RunMenu()
        {
            List<Person> persons = new List<Person>();
            bool isRunning = true;
            int userOption;
            // switch meny
            while (isRunning)
            {
                Console.WriteLine("1. Add person to list\n2. Print the list\n3. Print all men in the list\n4. Search by name\n5. Exit");

                while (!int.TryParse(Console.ReadLine(), out userOption)) { Console.WriteLine("Only integers"); }

                switch (userOption)
                {
                    case 1:
                        AddPerson(persons);
                        break;
                    case 2:
                        PrintAll(persons);
                        break;
                    case 3:
                        PrintMen(persons);
                        break;
					case 4:
                        SearchByName(persons);
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Select option 1-5.");
                        break;
                }
            }
        }

        public static void AddPerson(List<Person> list)
        {
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gender:");
            string gender = Console.ReadLine();
            Console.Write("Address:");
            string address = Console.ReadLine();

            if (age < 18)
            {
                Child newChild = new Child(name, age, gender, address);
                list.Add(newChild);
            }
            else
            {
                Adult newAdult = new Adult(name, age, gender, address);
                list.Add(newAdult);
            }
        }
        public static void PrintAll(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name}\n{person.Age}\n{person.Gender}\n{person.Address}\n");
            }
        }

        public static void PrintMen(List<Person> list)
        {
            foreach (Person person in list)
            {
                if (person.Gender == "Male")
                {
                    Console.WriteLine($"{person.Name}\n{person.Age}\n{person.Gender}\n{person.Address}\n");
                }
            }
        }

        public static void SearchByName(List<Person> list)
		{
			Console.WriteLine("Enter name:");
			string nameToFind = Console.ReadLine();

            Person result = list.Find(e => e.Name.Contains(nameToFind));

            Console.WriteLine($"{result.Name}\n{result.Age}\n{result.Gender}\n{result.Address}\n"); // Exeption is thrown when result == null
		}
    }
}
