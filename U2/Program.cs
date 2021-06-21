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
            Console.WriteLine("0 Exit");
            //Console.WriteLine("4");
            do
            {
                Console.WriteLine("Ange menyval: ");
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
                   /* case "4":
                        MenuS();
                        break; */
                    case "S":       
                    case "s":
                        MenuS();
                        break;
                    default:
                        Console.WriteLine("Felaktig input!");
                        break;
                }
            } while (true);
        }


        private static void Menu1()
        {
            //int Price = 0;
            Console.WriteLine("Ange ålder i siffror");
            int age = int.Parse(Console.ReadLine());
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80 kr");
            }
            else
            if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90 kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120 kr");
            }

        }
        private static void Menu2()
        {
            Console.WriteLine("Skriv något: ");
            string input = Console.ReadLine();  // läser in en sträng 
            for (int ii = 0; ii < 10; ii++)  // upprepar det användaren angivit 10 gånger
            {
                Console.Write(input + " ");

            }
            Console.WriteLine("\r\n");  //radbryt +ny rad
        }


        private static void Menu3()
        {
            Console.WriteLine("Skriv något: ");
            //var odds = new[] { };
            string input3 = Console.ReadLine();   // läser in en sträng 
            var odds3 = input3.Split(" ");       // delar upp strängen med brytning vid blanksteg
            Console.WriteLine(odds3[2]);        // skriver ut 3:e delsträngen

        }
        private static void MenuS()
        {   // räknar ihop pris för flera biobesökare baserat på ålder
            Console.WriteLine("Ange antal: ");
            int Antal = int.Parse(Console.ReadLine());
            //int ages = 10;
            string[] age = new string[Antal];
            string[] Alder = age;
            int a = 0;
            int Price = 0;
            do
            {
                Console.WriteLine("Ange ålder för person " + (a+1) + ": ");
                Alder[a] = Console.ReadLine();
                int ageinst = int.Parse(Alder[a]);
                a++;

                if (ageinst < 20)
                {
                    Console.WriteLine("Ungdomspris: 80 kr");
                    Price += 80;
                }
                else
                if (ageinst > 64)
                {
                    Console.WriteLine("Pensionärspris: 90 kr");
                    Price += 90;
                }
                else
                    Price += 120;
            }
            while (a < Antal) ;
            
                Console.WriteLine("Antal personer i sällskapet: " + Antal);
                Console.WriteLine("Pris för sällskap: " + Price + "\r\n");
            Console.WriteLine();

        }   
    }
}
