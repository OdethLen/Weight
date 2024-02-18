
using System;
namespace W
{
class Program
    {
        static void Main(string[] args) 
        {
            Box box1 = new Box();
            box1.Mass = 35;
            Console.WriteLine("Mass:"+box1.Mass);

            Console.WriteLine("The weight of the object is:"+box1.CalculateWeight()+" N");
        }
    }
}