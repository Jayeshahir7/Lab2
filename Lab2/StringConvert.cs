using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class StringConvert
    {
        public string s;
        public void Get()
        {
            Console.WriteLine("Enter String:-");
            s = Console.ReadLine();

            string result = ReplaceData(s);
            Console.WriteLine(result);
        }
        public string ReplaceData(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    chars[i]=char.ToLower(chars[i]);
                }
                else if(char.IsLower(chars[i]))
                {
                    chars[i]=char.ToUpper(chars[i]);
                }
            }
            return new string(chars);
        }
    }
}
