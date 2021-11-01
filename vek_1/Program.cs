using System;

namespace vek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double rok_narozeni;
            double aktualni_rok;
            double vek;
            double dotaz;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            while(true)
            {
             Console.Clear();
             Console.SetCursorPosition (10,5);
             Console.WriteLine("╔═══════════════════════════╗");
             Console.SetCursorPosition(10, 6);
             Console.WriteLine("║                           ║ ");
             Console.SetCursorPosition(10,7);
             Console.WriteLine("╚═══════════════════════════╝");
             Console.SetCursorPosition(10, 10);
             Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════╗");
             Console.SetCursorPosition(10, 11);
             Console.WriteLine("║                                                                                      ║ ");
             Console.SetCursorPosition(10, 12);
             Console.WriteLine("║                                                                                      ║ ");
             Console.SetCursorPosition(10, 13);
             Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════════════╝");
             Console.SetCursorPosition(10, 15);
             Console.WriteLine("╔═══════════════════════════╗");
             Console.SetCursorPosition(10, 16);
             Console.WriteLine("║                           ║ ");
             Console.SetCursorPosition(10, 17); 
             Console.WriteLine("║                           ║ ");
             Console.SetCursorPosition(10, 18);
             Console.WriteLine("╚═══════════════════════════╝");
             Console.SetCursorPosition(11,6);
             Console.WriteLine("Zadej rok narození: ");
             Console.SetCursorPosition(30, 6);
             double.TryParse(Console.ReadLine(), out rok_narozeni);
             aktualni_rok = DateTime.Now.Year;
             if ((rok_narozeni < 1900) || (rok_narozeni > aktualni_rok))
             {
             
             }
             else 
             {
              Console.SetCursorPosition(11, 11);
              Console.WriteLine("Pokud si tento rok už měl narozeniny stiskni (enter), pokud ne tak (1) a (enter)");
              Console.SetCursorPosition(11,12);
              double.TryParse(Console.ReadLine(), out dotaz);
              if (dotaz is 1)
              {
              rok_narozeni = rok_narozeni + 1;
              }
                
              aktualni_rok = DateTime.Now.Year;
              if ((rok_narozeni < 1900) || (rok_narozeni >aktualni_rok))
              {
                    
              }
              else
              {                                                      
              vek = aktualni_rok - rok_narozeni;
              string str_vek = vek.ToString();
                if (vek <= 10) 
                {
                 Console.SetCursorPosition(11, 17);
                 Console.WriteLine("Jsi ještě dítě ");
                }
                if ((vek >10 ) && (vek <=18))
                {
                 Console.SetCursorPosition(11, 17);
                 Console.WriteLine("Jsi teenager ");
                }
                if ((vek >18 )&& (vek <= 60))
                {
                 Console.SetCursorPosition(11, 17);
                 Console.WriteLine("Jsi dospělý");
                }
                if (vek >60)
                {
                 Console.SetCursorPosition(11, 17);
                 Console.WriteLine("Jsi důchodce");
                }
               Console.SetCursorPosition(11, 16);
               Console.WriteLine("Je ti " + str_vek);
               Console.ReadLine();
              }
             }
            }



        }
        
    }
}
