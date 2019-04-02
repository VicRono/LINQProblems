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
        }
    }
}
