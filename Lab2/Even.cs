using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Even
    {
        public void Display()
        {
            try
            {
                int no;
                Console.Write("Enter a Number:-");
                no = Convert.ToInt32(Console.ReadLine());
                if (no % 2 != 0)
                {
                    throw new ArgumentException("Number is not even...");
                }
                else
                {
                    Console.WriteLine("The Number Is Even..." + no);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("An error occurred:: " + ex.Message);
            }
         }
    }
}
