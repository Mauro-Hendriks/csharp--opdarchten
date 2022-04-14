using System;

namespace Getters_en_Setters
{
    static class Dog
    {
        private static Paw Golden = new Paw("Return");

        public static void SetPaw(Paw Jack)
        {
            Golden = Jack;
        }
        public static Paw GetPaw()
        {
            return Golden;
        }
    }
    class Paw
    {
        public string name = "woof";

        public Paw(string temp)
        {
            name = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paw bark = Dog.GetPaw();
            Console.WriteLine(bark.name);
        }
    }
}
