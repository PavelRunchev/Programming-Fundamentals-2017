using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Demon
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public string Name { get; set; }
    }
    class NetherRealms
    {
        static void Main()
        {
            List<Demon> dataDemons = new List<Demon>();
            string[] inputDemons = Console.ReadLine()
                .Split(new char[] { ',', ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputDemons.Length; i++)
            {
                string demonName = inputDemons[i];
                double health = CalcHealth(demonName);
                double damage = CalcDamage(demonName);
                damage = MultiplyDamage(damage, demonName);
                damage = DevideDamage(damage, demonName);
                Demon demon = new Demon();
                demon.Name = demonName;
                demon.Health = health;
                demon.Damage = damage;
                dataDemons.Add(demon);
            }
            PrintAllDemons(dataDemons);
        }

        private static void PrintAllDemons(List<Demon> dataDemons)
        {
            var sortedDemons = dataDemons.OrderBy(n => n.Name).ToList();
            foreach (var demon in sortedDemons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        private static double DevideDamage(double damage, string demonName)
        {
            for (int i = 0; i < demonName.Length; i++)
            {
                if (demonName[i] == '/')
                {
                    damage /= 2;
                }
            }
            return damage;
        }

        private static double MultiplyDamage(double damage, string demonName)
        {
            for (int i = 0; i < demonName.Length; i++)
            {
                if(demonName[i] == '*')
                {
                    damage *= 2;
                }
            }
            return damage;
        }

        private static double CalcDamage(string demonName)
        {
            double sumDamage = 0;
            string pattern = @"[\+\-]?[\d]+(?:[\.]*[\d]*)";
            Regex regex = new Regex(pattern);
            MatchCollection digitIsMatched = regex.Matches(demonName);
            foreach (var item in digitIsMatched)
            {
                sumDamage += double.Parse(item.ToString());
            }
            return sumDamage;
        }
   
        private static double CalcHealth(string demonName)
        {
            double sumHelth = 0;
            for (int i = 0; i < demonName.Length; i++)
            {
                int letter = (int)demonName[i];
                 if(letter < 42 || letter > 57)
                {
                    sumHelth += (int)letter;
                }
            }
            return sumHelth;
        }
    }
}
