using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface MyInterface
    {
        public void Addition();
        public void Subtraction();
    }
    internal class InterfaceCal:MyInterface
    {
        int a, b, c;
        public void GetData()
        {
            Console.WriteLine("Enter number 1:-");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:-");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void Addition()
        {
            
            Console.WriteLine("----Addition----");
            GetData();
            c = a + b;
            Console.WriteLine("Ans:-"+c);

        }

        public void Subtraction()
        {
            Console.WriteLine("----Subtraction----");
            GetData();
            c = a - b;
            Console.WriteLine("Ans:-" + c);

        }

    }
}
