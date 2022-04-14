using System;

namespace Clases
{
    class Rekenmachine
    {

        static void Main()
        {
            Console.WriteLine("1 = +, 2 = /, 3 = * ");
            string input = Console.ReadLine();

            int myInt = Int32.Parse(input);
            Rekenmachine rekenmachine = new Rekenmachine();

            switch (myInt)
            {
                case 1:
                    rekenmachine.add();
                    break;

                case 2:
                    rekenmachine.dup();
                    break;

                case 3:
                    rekenmachine.multi();
                    break;

                default:
                    string Not = "dit is geen nummer";
                    int mystring = Int32.Parse(Not);
                    break;
            }
        }
     
        
        public int add()
        {
            string Eerste = "hey";
            string Tweede = "hoi";
            int ErN = 1;
            int TwN = 2;
            int Totaal = 3;
            Console.Clear();
            Console.WriteLine("wat is het eerste nummer");
            Eerste = Console.ReadLine();
            ErN = Int32.Parse(Eerste);


            Console.WriteLine("wat is het tweede nummer");
            Tweede = Console.ReadLine();
            TwN = Int32.Parse(Tweede);

            Totaal = (ErN + TwN);
            Console.WriteLine(Totaal);
            return Totaal;

        }
        public int dup()
        {
            string Eerste = "hey";
            string Tweede = "hoi";
            int ErN = 1;
            int TwN = 2;
            int Totaal = 3;
            Console.Clear();
            Console.WriteLine("wat is het eerste nummer");
            Eerste = Console.ReadLine();
            ErN = Int32.Parse(Eerste);


            Console.WriteLine("wat is het tweede nummer");
            Tweede = Console.ReadLine();
            TwN = Int32.Parse(Tweede);

            Totaal = (ErN / TwN);
            Console.WriteLine(Totaal);
            return Totaal;

        }
        public int multi()
        {
            string Eerste = "hey";
            string Tweede = "hoi";
            int ErN = 1;
            int TwN = 2;
            int Totaal = 3;
            Console.Clear();
            Console.WriteLine("wat is het eerste nummer");
            Eerste = Console.ReadLine();
            ErN = Int32.Parse(Eerste);


            Console.WriteLine("wat is het tweede nummer");
            Tweede = Console.ReadLine();
            TwN = Int32.Parse(Tweede);

            Totaal = (ErN * TwN);
            Console.WriteLine(Totaal);
            return Totaal;

        }
    }
}
