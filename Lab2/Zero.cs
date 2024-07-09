using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Zero
    {
        int num1, num2,ans;
        public void zeroexception()
        {
            Console.WriteLine("Enter the Number1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                
                ans=num1/num2;
                Console.WriteLine("Ans=" + ans);
                
                
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Zero exception: {e.Message}");
            } 
        }
    }
}
