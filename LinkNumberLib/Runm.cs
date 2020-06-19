using System;
using System.Reflection;
using System.Threading.Tasks;
using LinkNumberLib;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkNumberLib
{
    public class Runm
    {
        public static List<string> MainMethodArgs = new List<string>();
        public static void Restart()
        {
            Run(MainMethodArgs.ToArray());
        }
        public static void Run(string[] args)
        {
            Console.WriteLine("Witaj w grze 'Link Number'!");
            Console.WriteLine("Twoim zadaniem jest dopasowanie liczb i operatorów w działaniu tak, aby otrzymać wyświetloną liczbę jako wynik.");
            Console.WriteLine("Na początku musisz wybrać poziom trudności: 1 lub 2.");
            Console.WriteLine("Poziomy różnią się ilością możliwych liczb w działaniu.");
            Console.WriteLine("Na poziomie 1 należy użyć 3 liczb aby otrzymać wynik, poziom 2 z kolei wymaga 4 liczb.");
            Console.Write("wybierz poziom: ");

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


                Console.WriteLine("Aby zagrać jeszcze raz wybierz 'Z'. Aby wyjśc z gry wybierz 'W'.");
                string cb = Console.ReadLine();
                if (cb.ToUpper() == "Z")
                {
                    Restart();
                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("na razie innych lvlow nie ma");
            }
        }
    }
}
