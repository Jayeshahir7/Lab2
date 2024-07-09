using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Indexout
    {
        int[] num = new int[5];
        public void index()
        {
            try 
            {
                for (int i = 0; i < num.Length+1; i++)
                {
                    Console.WriteLine("Enter Number:");
                    num[i]=Convert.ToInt32(Console.ReadLine());
                }
                

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Index Out of Range exception: {e.Message}");
            }
        }
    }
}
