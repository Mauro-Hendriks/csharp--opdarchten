using System;

namespace Overerving
{
    class animal
    {
        public void Feed()
        {

        }
    }
    class horse : animal
    {
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            horse myanimal = new horse();

            myanimal.Feed();
        }
    }
}
