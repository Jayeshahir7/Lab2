using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class CaseChange
    {
        public void  casechange()
        {
            Console.Write("Enter A Character:-");
            char c = Convert.ToChar(Console.ReadLine());

            char c2 = c.ToString().ToUpper().ToCharArray()[0];
            Console.WriteLine("Change="+c2);


        }

    }
}
