using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> wordsWithTH = words.Where(s => s.Contains("th")).ToList();
            foreach(var s in wordsWithTH)
            {

                Console.WriteLine(s.ToString());
                    
                
            }

            Console.ReadLine();




        }
    }
}
