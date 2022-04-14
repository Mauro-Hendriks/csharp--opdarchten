using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Just = new int[] { 10, 20, 30, 40, 50, 60 };

            int Tot = Just.Sum();
            Console.WriteLine(Tot);
           
        }
    }
}
