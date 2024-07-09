using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class LongestWord
    {
        public void Word() 
        {
            string s;
            Console.WriteLine("Enter String:-");
            s= Console.ReadLine();

            List<String> word=s.Split(" ").ToList();
            string LongestWord = "";

            foreach (var item in word)
            {
                if(LongestWord.Length<item.Length)
                {
                    LongestWord = item;
                }
                
            }
            Console.WriteLine("Longest Word:-"+LongestWord);
        }
    }
}
