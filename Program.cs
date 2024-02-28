using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Threading.Channels;

namespace Uppg_6_3
{
    class Program
    {
        public static void Main(string[] args) //Huvdprogram
        {
            string svar = " ";

            while (svar != "j")
            {
                Console.WriteLine("Välj ett alternativ.");
                Console.WriteLine("1. Addera tre tal.");
                Console.WriteLine("2. Hitta största talet.");
                Console.WriteLine("3. Avsluta program.");
                string menyval = Console.ReadLine();

                switch (menyval)
                {
                    case "1": //Första menyval
                        Console.WriteLine("Skriv in det första talet.");
                        int tal1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Skriv in det andra talet.");
                        int tal2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Skriv in det tredje och sista talet nu.");
                        int tal3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Summan av de tre talen blir: {Adderatretal(tal1, tal2, tal3)} ");
                        break;

                    case "2": //Andra menyval
                        Console.WriteLine("Skriv in ett tal.");
                        int talett = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Härligt, skriv in nästa tal nu, som ska jämföras med den första.");
                        int taltvå = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Det största talet mellan de två du skrev är: {störstatal}");
                        break;

                    case "3":
                        Console.WriteLine("Är du säker? J/N");
                        string svar1 = Console.ReadLine().ToLower();
                        
                        if (svar1 == "j")
                        {
                            Environment.Exit(0);
                        }
                        if (svar == "n")
                        {
                            Console.WriteLine();
                        }
                        break;
                }



            }
        }

        static int Adderatretal(int tal1, int tal2, int tal3) //Addering
        {
            int summa = tal1 + tal2 + tal3;
            return summa;
        }
        static int störstatal(int tal1, int tal2) //Störstatal
        {
            int störstatal = tal1;
            if (tal2 > tal1)
            {
                tal2 = störstatal;
            }
            return störstatal;
        }

    }
}