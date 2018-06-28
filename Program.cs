using System;
using System.Collections.Generic;
namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var answers = new List<answer>();
            bool running = true;
            string response;

            while (running)
            {
                Console.WriteLine("What would you like to do?");
                response = Console.ReadLine();

                switch (response)
                {
                    case "display":
                        
                        foreach (var item in answers)
                        {
                            Console.WriteLine(item.name);
                            Console.WriteLine(item.age);
                            Console.WriteLine(item.month);
                            Console.WriteLine("\n");
                        }

                        break;

                    case "enter":
                        var newEntry = new answer();

                        Console.WriteLine("what is the name?");
                        newEntry.name = Console.ReadLine();

                        Console.WriteLine("what is your age?");
                        newEntry.age = int.Parse(Console.ReadLine());

                        Console.WriteLine("what is the month of your birth?");
                        newEntry.month = Console.ReadLine();

                        answers.Add(newEntry);

                        break;

                    case "close":
                        running = false;
                        break;
                }
            }
        }
    }

    class answer 
    {
        public string name;
        public int age;
        public string month;
    }
}
