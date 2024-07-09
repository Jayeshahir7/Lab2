using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class sum
    {
        public abstract  int SumOfTwo(int x, int y);
        public abstract  int SumOfThree(int x, int y,int z);
    }
    internal class Calculate:sum
    {
       public override int SumOfTwo(int x,int y)
        {
            return x + y;
        }

        public override int SumOfThree(int x, int y,int z)
        {
            return x + y + z;
        }


    }
}
