using System;

// another comment
// Force sonarCloud action
namespace PlaygroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Just before hell world!");
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hell world! In a loop");
                 i+= 2;
            }
        }
    }
}
