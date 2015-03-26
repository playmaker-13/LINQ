using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_LINQ_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };
            string[] towns = { "Мельбурн", "Оттава", "Боруссия", "Мадрид", "Барселона"};

            var selectedTowns = towns.Where(q => q.ToUpper().StartsWith("М")).OrderBy(q => q);
            var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
            int num = (from i in towns where i.ToUpper().StartsWith("М") select i).Count();
            int number = (from t in teams where t.ToUpper().StartsWith("Б") select t).Count();
            foreach (var s in selectedTowns)
                Console.WriteLine(s);
            Console.WriteLine(num);
            foreach (string s in selectedTeams)
                Console.WriteLine(s);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
