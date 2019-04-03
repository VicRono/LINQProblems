using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Using LINQ, write a function that returns all words that contain the substring “th” from a list
            //use.Contain() to find "th", create new list, print results
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var newList = words.Where(m => m.Contains("th"));
            foreach (var el in newList)
            {
                Console.WriteLine(el);
            }

            Console.ReadLine();

            //2.Using LINQ, write a function that takes in a list of strings and returns a copy of thelist without duplicates.
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var substring = names.Distinct();
            foreach (var le in substring)
            {
                Console.Write(le);
            }

            Console.ReadLine();
            
            //3.Using LINQ, write a function that calculates the class grade average after dropping the lowest grade for each student.
            //The function should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"),
            //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
            //split at first index-create new string-convert it to int
            //compare each value and delete the lowest with each iteration
            //create another list-iterate and find average
            //repeat the steps for each index
            //find average
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            //use double since int cannot contain decimals
            List<double> avrgList2 = new List<double>();
            for (int i = 0; i < classGrades.Count; i++)
            {
                var avrgList1 = classGrades[i].Split(',').Select(m => Int32.Parse(m)).OrderBy(l => l).Skip(1).Average();
                avrgList2.Add(avrgList1);
            }
            var averageGrade = avrgList2.Average();
            Console.WriteLine(averageGrade);
            Console.ReadLine();
        }
    }
}
