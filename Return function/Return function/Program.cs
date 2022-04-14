using System;

namespace Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test1());
        }

        public static string Test1()
        {
            Random rnd = new Random();
            int D20 = rnd.Next(1, 20);



            string Totaal = Convert.ToString(D20);
            return Totaal;
            

        }
    }
}
