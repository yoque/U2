using System;

namespace U2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Huvudmeny, var god ange ditt val för att komma vidare ()");

            do
            {
                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Felaktig input!");
                        break;
                }
            } while (true);

    {

            }

            Console.WriteLine();
          
          
          
          
          
          
          
          
          
        }

        public int Sway();
    }
}
