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
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            int[] numbers1 = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            /*with LINQ*/
            var selectedTowns = towns.Where(q => q.ToUpper().StartsWith("М")).OrderBy(q => q);
            var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
            /*compare with LINQ*/
            int num = (from i in towns where i.ToUpper().StartsWith("М") select i).Count();
            int number = (from t in teams where t.ToUpper().StartsWith("Б") select t).Count();
            /**/
            /*without LINQ*/
            IEnumerable<int> odds = from j in numbers where j % 2 != 0 && j > 10 select j;
            IEnumerable<int> evens = from i in numbers where i % 2 == 0 && i > 10 select i;
            /*with LINQ*/
            IEnumerable<int> odds1 = numbers1.Where(j=> j % 2 != 0 && j >= 10);
            IEnumerable<int> evens1 = numbers1.Where(i => i % 2 == 0 && i >= 10);
            /**/
            foreach (var s in selectedTowns)
                Console.WriteLine(s);
            Console.WriteLine(num);
            foreach (string s in selectedTeams)
                Console.WriteLine(s);
            Console.WriteLine(number);
            
            foreach (int i in odds) Console.Write("{0}, ", i);
            Console.WriteLine();
            foreach (int i in evens) Console.Write("{0}, ", i);
            Console.WriteLine();
            foreach (int i in odds1) Console.Write("{0}, ", i);
            Console.WriteLine();
            foreach (int i in evens1) Console.Write("{0}, ", i);
            Console.WriteLine();

            List<User> users = new List<User>();
            users.Add(new User { Name = "Jack", Age = 22 });
            users.Add(new User { Name = "Mike", Age = 11 });
            users.Add(new User { Name = "Sam", Age = 43 });
            users.Add(new User { Name = "Tom", Age = 33 });
            /*without LINQ*/
            
            var names = from u in users select u.Name;
            foreach (string s in names) Console.WriteLine(s);
            
            var items = from j in users 
                        select new                          
                                 { FirstName = j.Name, YearOfBirth = DateTime.Now.Year - j.Age };
            foreach (var n in items)
                Console.WriteLine("{0} - {1}", n.FirstName, n.YearOfBirth);
            

            /*with LINQ*/
            // выборка имен
            var names1 = users.Select(i => i.Name);
            
            // выборка объектов анонимного типа
            var items1 = users.Select(i => new 
            { FirstName = i.Name, YearOfBirth = DateTime.Now.Year - i.Age });

            foreach (var i in names1) Console.WriteLine(i);
            foreach (var j in items1) Console.WriteLine(j);
            
            
            
            Console.ReadLine();
        }
    }
}
