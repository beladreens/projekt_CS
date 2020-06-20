using System;
using System.Reflection;
using System.Threading.Tasks;
using LinkNumberLib;
using System.Collections.Generic;
using System.Linq;

namespace LinkNumerConsoleApp
{
    class MainApp
    {
        public static List<string> MainMethodArgs = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze 'Link Number'!");
            Console.WriteLine("Twoim zadaniem jest dopasowanie liczb i operatorów w działaniu tak, aby otrzymać wyświetloną liczbę jako wynik.");
            Console.WriteLine("Na początku musisz wybrać poziom trudności: 1 lub 2.");
            Console.WriteLine("Poziomy różnią się ilością możliwych liczb w działaniu.");
            Console.WriteLine("Na poziomie 1 należy użyć 3 liczb aby otrzymać wynik, poziom 2 z kolei wymaga 4 liczb.");
            Console.Write("wybierz poziom: ");

            MainMethodArgs = args.ToList();
            Runm.Run(MainMethodArgs.ToArray());
        }
    }
}
