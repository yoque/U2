using System;

namespace U2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Huvudmeny, var god ange ditt val för att komma vidare ()");
            Console.WriteLine("1: Ungdom (under 20 år) eller pensionär (äldre än 64 år)");
            Console.WriteLine("2 Upprepning 10 ggr");
            Console.WriteLine("3 skriv ut tredje ordet");
            Console.WriteLine("S Pris för sällskap");
            Console.WriteLine("4");
            do
            {
                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Menu1();
                        break;
                    case "2":
                        Menu2();
                        break;
                    case "3":
                        Menu3();
                        break;
                    case "4":
                        MenuS();
                        break;
                    case "S":
                        MenuS();
                        break;
                    default:
                        Console.WriteLine("Felaktig input!");
                        break;
                }
            } while (true);



            Console.WriteLine("Menyval 1: Ungdom (under 20 år) eller pensionär (äldre än 64 år)");
            if (Console.ReadLine() == "1")
            {
                Menu1();
            }



        }


        private static void Menu1()
        {
            int Price = 0;
            Console.WriteLine("Ange ålder i siffror");
            int age = int.Parse(Console.ReadLine());
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
                Price += 80;
            }
            else
            if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }

        }
        private static void Menu2()
        {
            string input = Console.ReadLine();
            for (int ii = 0; ii < 10; ii++)
            {
                Console.Write(input + " ");

            }
        }


        private static void Menu3()
        {

            //var odds = new[] { };
            string input3 = Console.ReadLine();
            var odds3 = input3.Split(" ");
            Console.WriteLine(odds3[2]);



            //foreach (string author in authorsList)
            //  Console.WriteLine(author);

        }
        private static void MenuS()
        {
            int Antal = int.Parse(Console.ReadLine());
            int ages = 10;
            string[] ag = new string[ages];
            string[] Alder = ag;
            int a = 0;



            //for (int a = 0; a < 100; a++)

            do
            {
                Alder[a] = Console.ReadLine();
                a++;
            }
            while (Console.ReadLine()!=null);
        }
        
       // public int Sway();
    }
}
