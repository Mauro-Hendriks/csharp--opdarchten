using System;

namespace Variables_en_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Ben = rnd.Next(0, 2);
            float Con = Ben;
            Console.WriteLine(Con);

            int Dep = 75 ;
            char Pro = Convert.ToChar(Dep);
            Console.WriteLine(Pro);
        }
    }
}
