using System;

namespace Switch_cases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A number between 0-5");
            string input = Console.ReadLine();

            int myInt = Int32.Parse(input);

            switch (myInt)
            {
                case 0:
                    Console.WriteLine("hallo, dit is case 0");
                    break;

                case 1:
                    Console.WriteLine("hallo, dit is case 1");
                    break;
                case 2:
                    Console.WriteLine("hallo, dit is case 2");
                    break;
                case 3:
                    Console.WriteLine("hallo, dit is case 3");
                    break;
                case 4:
                    Console.WriteLine("hallo, dit is case 4");
                    break;
                case 5:
                    Console.WriteLine("hallo, dit is case 5");
                    break;
                default:
                    Console.WriteLine("Dat is geen nummer wat hier in staat");
                    break;
            }

            

            
            
            }
    }
}
