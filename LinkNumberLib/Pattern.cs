using System;

namespace LinkNumberLib
{
    /// <summary>
    /// schemat, według którego będą realizowane kolejne poziomy, generowane w nich liczby
    /// </summary>
    public class Pattern
    {
        // dane - pola
        public static Random rnd = new Random();

        // konstruktor
        public class Poziom1 : Pattern
        {
            static int[] wyniki = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int wynik = (wyniki[rnd.Next(0, 9)]);

            public void Poziom1Method()
            {
                
            }
        }

        

        public class Poziom2 : Pattern
        {
            int wynik = rnd.Next(1, 54);
            int a, b, c, d;
        }

        /*public class Poziom3 : Pattern
        {
            int wynik = rnd.Next(1, 81);
            int a, b, c, d, e;
        }*/

        // działania - metody
        
    }
}
