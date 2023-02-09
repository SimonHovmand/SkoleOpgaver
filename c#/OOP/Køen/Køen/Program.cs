namespace Køen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> queue = new Queue<Person>();

            bool on = true;

            while (on)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("======================");
                Console.WriteLine("     Craisy Daisy");
                Console.WriteLine("======================");
                Console.WriteLine("1. Add items");
                Console.WriteLine("2. Delete items");
                Console.WriteLine("3. Show the number of items");
                Console.WriteLine("4. Show min and max items");
                Console.WriteLine("5. Print all items");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: 1\n");
                Console.ForegroundColor = ConsoleColor.Blue;

                if (Byte.TryParse(Console.ReadLine(), out byte input))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Navn på personen.");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            string name = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Alder på personen.");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            byte age = Convert.ToByte(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;

                            Person person = new Person(name, age);

                            queue.Enqueue(person);
                            Console.WriteLine(person.Name + " på " + person.Age + " er blevet tilføjet til køen.\n");
                            break;
                        case 2:
                            queue.Dequeue();
                            Console.WriteLine("1. person i køen, er blevet fjernet!\n");
                            break;
                        case 3:
                            if (queue.Count > 0)
                            {
                                Console.WriteLine("Der er: " + queue.Count + " personer i køen.\n");
                            }
                            else
                            {
                                Console.WriteLine("Der er ingen personer i køen.\n");
                            }

                            break;
                        case 4:
                            Console.WriteLine("Første i køen er: " + queue.First().Name + " " + queue.First().Age);
                            Console.WriteLine("Sidste i køen er: " + queue.Last().Name + " " + queue.Last().Age);
                            break;
                        case 5:
                            foreach (Person persons in queue)
                            {
                                Console.WriteLine(persons.Name + " " + persons.Age);
                            }
                            Console.WriteLine(" ");
                            break;
                        case 6:
                            on = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fejl inkorekt nummer!\n");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fejl!");
                    Console.WriteLine("Angiv et tal\n");
                }
            }
        }
    }
}