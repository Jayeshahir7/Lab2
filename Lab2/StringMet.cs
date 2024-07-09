using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class StringMet
    {
        public void Display()
        {
            string str = "JayeshAhir";
            Console.WriteLine("Original String:-"+str);
            Console.WriteLine("Length of String:-"+str.Length);
            Console.WriteLine("Upper Case of String:-"+str.ToUpper());
            Console.WriteLine("Lower Case of String:-" + str.ToLower());
            Console.WriteLine("SubString:-"+str.Substring(2));
            Console.WriteLine("SubString:-"+ str.Substring(1,5));
            Console.WriteLine("Remove:-"+str.Remove(6));
            Console.WriteLine("Replace:-" + str.Replace('y', 'Y'));
            Console.WriteLine("Contains:-"+str.Contains("Ahir"));


        }
    }
}
