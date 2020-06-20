using System;

namespace LinkNumberLib
{
    public class Poziom1
    {
        public int wynik;
        private int[] wyniki;
        public static string scr;
        public static Random rnd = new Random();

        public Poziom1()
        {
            wyniki = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            wynik = (wyniki[rnd.Next(0, 9)]);

            scr = wynik.ToString();
        }

        public void GetNumbers()
        {
            switch (wynik)
            {
                case 10:
                    Console.WriteLine("2 2 6; operatory * -");
                    char[] czyt = new char[5];
                    czyt = Console.ReadLine().ToCharArray(0,5);
                    char a = czyt[0]; int al = (int)(a - '0');
                    char znak1 = czyt[1];
                    char b = czyt[2]; int bl = (int)(b - '0');
                    char znak2 = czyt[3];
                    char c = czyt[4]; int cl = (int)(c - '0');
                    int part1;

                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '-')
                        {
                            if ((part1 - cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 - cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 - cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 - cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 11:
                    Console.WriteLine("4 8 1; operatory + -");
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '-')
                        {
                            if ((part1 - cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 - cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            if ((part1 + cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 + cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 12:
                    Console.WriteLine("2 4 6; operatory * /");
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '/')
                        {
                            if ((part1 / cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 / cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '/')
                    {
                        part1 = al / bl;
                        if (czyt[3] == '/') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 * cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 * cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 13:
                    Console.WriteLine("3 7 8; operatory * -");
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '-')
                        {
                            if ((part1 - cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 - cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 + cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 + cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 14:
                    Console.WriteLine("3 6 4; operatory * -");
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '-')
                        {
                            if ((part1 - cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 - cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 * cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 * cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 15:
                    Console.WriteLine("3 3 6; operatory - *");
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '*' || czyt[1] == '/')
                    {
                        if (czyt[1] == '*')
                        {
                            part1 = al * bl;
                            if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                            if (czyt[3] == '-')
                            {
                                if ((part1 - cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part1 - cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                        if (czyt[1] == '-')
                        {
                            part1 = al - bl;
                            if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                            if (czyt[3] == '*')
                            {
                                if ((part1 * cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part1 * cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    break;

                case 16:
                    Console.WriteLine("2 5 6; operatory + *");
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            if ((part1 + cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 + cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 * cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 * cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 17:
                    Console.WriteLine("3 4 5; operatory + *");
                    czyt = new char[5];
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            if ((part1 + cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 + cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 * cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 * cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 18:
                    Console.WriteLine("2 4 7; operatory + *");
                    czyt = new char[5];
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 * cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 * cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            if ((part1 + cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 + cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                case 19:
                    Console.WriteLine("1 2 9; operatory + *");
                    czyt = new char[5];
                    czyt = Console.ReadLine().ToCharArray(0, 5);
                    a = czyt[0]; al = (int)(a - '0');
                    znak1 = czyt[1];
                    b = czyt[2]; bl = (int)(b - '0');
                    znak2 = czyt[3];
                    c = czyt[4]; cl = (int)(c - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            if ((part1 * cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 * cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            if ((part1 + cl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                            if ((part1 + cl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Wprowadź odpowiednie liczby i operatory bez spacji, a także bez znaku równości!");
                    Console.WriteLine("Przykład: 1+2-3");
                    break;
            }
        }
    }   
}