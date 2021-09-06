using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // 5.Birthday Celebrations

            List<IBirthable> birthables = new List<IBirthable>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] partsStrings = line.Split();

                string type = partsStrings[0];

                if (type == nameof(Citizen))
                {
                    string name = partsStrings[1];
                    int age = int.Parse(partsStrings[2]);
                    string id = partsStrings[3];
                    string birthdate = partsStrings[4];

                    birthables.Add(new Citizen(name, age, id, birthdate));
                }
                else if (type == nameof(Pet))
                {
                    string name = partsStrings[1];
                    string birthdate = partsStrings[2];

                    birthables.Add(new Pet(name, birthdate));
                }
            }

            string filterYear = Console.ReadLine();

            List<IBirthable> fBirthables = birthables
                .Where(x => x.Birthdate.EndsWith(filterYear))
                .ToList();

            foreach (var birthable in fBirthables)
            {
                Console.WriteLine(birthable.Birthdate);
            }

            // 2.Multiple Implementation
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //string id = Console.ReadLine();
            //string birthdate = Console.ReadLine();

            //IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            //IBirthable birthable = new Citizen(name, age, id, birthdate);

            //Console.WriteLine(identifiable.Id);
            //Console.WriteLine(birthable.Birthdate);

            // 4.Border Control
            //List<IIdentifiable> identifiables = new List<IIdentifiable>();
            //while (true)
            //{
            //    string line = Console.ReadLine();

            //    if (line == "End")
            //    {
            //        break;
            //    }

            //    string[] tokens = line.Split();

            //    if (tokens.Length == 3)
            //    {
            //        string name = tokens[0];
            //        int age = int.Parse(tokens[1]);
            //        string id = tokens[2];

            //        identifiables.Add(new Citizen(name, age, id));
            //    }
            //    else
            //    {
            //        string model = tokens[0];
            //        string id = tokens[1];

            //        identifiables.Add(new Robot(id, model));
            //    }
            //}

            //string fakeId = Console.ReadLine();

            //var filter = identifiables
            //    .Where(x => x.Id.EndsWith(fakeId))
            //    .ToList();

            //foreach (var identifiable in filter)
            //{
            //    Console.WriteLine(identifiable.Id);
            //}
        }
    }
}
