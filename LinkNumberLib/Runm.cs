using System;
using System.Reflection;
using System.Threading.Tasks;
using LinkNumberLib;
using System.Data;
using System.Collections.Generic;

namespace LinkNumberLib
{
    public class Runm
    {
        public static List<string> MainMethodArgs = new List<string>();
        public static void Restart()
        {
            Console.Write("Wybierz 1 lub 2: ");
            Run(MainMethodArgs.ToArray());
        }

        public static void Choose()
        {
            Console.WriteLine("Aby zagrać jeszcze raz wybierz 'Z'. Aby wyjśc z gry wybierz 'W'.");
            string cb = Console.ReadLine();
            if (cb.ToUpper() == "Z")
            {
                Restart();
                Console.WriteLine();
            }
            if (cb.ToUpper() == "W")
            {
                System.Threading.Thread.Sleep(100);
                Environment.Exit(0);
            }
            else Console.WriteLine("Wybierz Z albo W.");
        }

        public static void Run(string[] args)
        {
            ConsoleKeyInfo wybor;
            wybor = Console.ReadKey();
            Console.WriteLine();

            if (wybor.KeyChar == '1')
            {
                Poziom1 lvl1 = new Poziom1();
                FieldInfo fld = typeof(Poziom1).GetField("scr");

                Console.Write("Liczba, którą należy otrzymać to ");
                Console.WriteLine(fld.GetValue(null));
                Console.Write("Wybierz liczby i operatory w odpowiedniej kolejności: ");

                lvl1.GetNumbers();

                Choose();
            }

            if (wybor.KeyChar == '2')
            {
                Poziom2 lvl2 = new Poziom2();

                Console.Write("Liczba, którą należy otrzymać to ");
                Console.WriteLine(lvl2.Scr2);
                Console.Write("Wybierz liczby i operatory w odpowiedniej kolejności: ");

                lvl2.GetNumbers2();

                Choose();
            }

            else Restart();
        }
    }
}
