using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            while (heroes.Count < n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero baseHero = CreateHero(type, name);

                if (baseHero == null)
                {
                    Console.WriteLine("Invalid h" +
                                      "ero!");
                    continue;
                }
                heroes.Add(baseHero);
            }
            
            int boss = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                boss -= hero.Power;
            }

            if (boss <= 0)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static BaseHero CreateHero(string type, string name)
        {
            BaseHero currHero = null;

            if (type == nameof(Druid))
            {
                currHero = new Druid(name);
            }
            else if (type == nameof(Paladin))
            {
                currHero = new Paladin(name);
            }
            else if (type == nameof(Warrior))
            {
                currHero = new Warrior(name);
            }
            else if (type == nameof(Rogue))
            {
                currHero = new Rogue(name);
            }
            return currHero;
        }
    }
}
