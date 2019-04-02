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
            

            //2.Using LINQ, write a function that takes in a list of strings and returns a copy of thelist without duplicates.
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var substring = names.Distinct();
            foreach (var le in substring)
            {
                Console.Write(le);
            }

            Console.ReadLine();
        }
    }
}
