using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface Shape
    {
        double Circal();
        double Triangle();
        double Square();
    }
    internal class Shapedemo:Shape
    {
        double radius,height,side,Base;

        public void Get()
        {
            Console.WriteLine("Enter Radius:-");
            radius=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Height:-");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Side:-");
            side = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Base:-");
            Base = Convert.ToDouble(Console.ReadLine());
        }
        public double Circal() { 
            return Math.PI * radius*radius;
        }

        public double Triangle() {
            return (0.5 * Base * height);
        }

        public double Square()
        {
            return side * side;

        }
    }
}
