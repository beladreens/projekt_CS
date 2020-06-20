using System;
using System.Collections.Generic;
using System.Text;

namespace LinkNumberLib
{
    class Poziom2
    {
        private int wynik;
        private string scr2;
        public string Scr2
        {
            get { return scr2; }
        }
        enum Wyniki2{
            Value1 = 20,
            Value2 = 27,
            Value3 = 36,
            Value4 = 42,
            Value5 = 45,
            Value6 = 24,
            Value7 = 30,
            Value8 = 40,
            Value9 = 50,
            Value10 = 35
        }
        void Reminder()
        {
            Console.WriteLine("Wprowadź odpowiednie liczby i operatory bez spacji, a także bez znaku równości!");
            Console.WriteLine("Przykład: 1+2-3");
        }
        public Poziom2()
        {
            Array values = Enum.GetValues(typeof(Wyniki2));
            Random random = new Random();
            Wyniki2 randomWyniki2 = (Wyniki2)values.GetValue(random.Next(values.Length));
            if (randomWyniki2 == Wyniki2.Value1) wynik = (int)Wyniki2.Value1;
            if (randomWyniki2 == Wyniki2.Value2) wynik = (int)Wyniki2.Value2;
            if (randomWyniki2 == Wyniki2.Value3) wynik = (int)Wyniki2.Value3;
            if (randomWyniki2 == Wyniki2.Value4) wynik = (int)Wyniki2.Value4;
            if (randomWyniki2 == Wyniki2.Value5) wynik = (int)Wyniki2.Value5;
            if (randomWyniki2 == Wyniki2.Value6) wynik = (int)Wyniki2.Value6;
            if (randomWyniki2 == Wyniki2.Value7) wynik = (int)Wyniki2.Value7;
            if (randomWyniki2 == Wyniki2.Value8) wynik = (int)Wyniki2.Value8;
            if (randomWyniki2 == Wyniki2.Value9) wynik = (int)Wyniki2.Value9;
            if (randomWyniki2 == Wyniki2.Value10) wynik = (int)Wyniki2.Value10;

            scr2 = wynik.ToString();
        }

        public void GetNumbers2()
        {
            switch(wynik)
            {
                case 20:
                    Console.WriteLine("2 4 6 8; operatory / * -");
                    char[] czyt = new char[7];
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    char a = czyt[0]; int al = (int)(a - '0');
                    char b = czyt[2]; int bl = (int)(b - '0');
                    char c = czyt[4]; int cl = (int)(c - '0');
                    char d = czyt[6]; int dl = (int)(d - '0');
                    int part1, part2;

                    if (czyt[1] == '/')
                    {
                        part1 = al / bl;
                        if (czyt[3] == '/') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '/')
                        {
                            part2 = part1 / cl;
                            if (czyt[5] == '*' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '*') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '/')
                            {
                                if ((part2 / dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 / dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '-')
                    {
                            part1 = al - bl;
                            if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                            if (czyt[3] == '*')
                            {
                                part2 = part1 * cl;
                                if (czyt[5] == '*' || czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatorów!");
                                if (czyt[5] == '/')
                                {
                                    if ((part2 / dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                    if ((part2 / dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                                }

                            }
                            if (czyt[3] == '/')
                            {
                                part2 = part1 / cl;
                                if (czyt[5] == '-' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                                if (czyt[5] == '*')
                                {
                                    if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                    if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                                }
                            }
                    }
                    break;

                case 27:
                    Console.WriteLine("0 3 9 9; operatory / * -");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '/')
                    {
                        part1 = al / bl;
                        if (czyt[3] == '/') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '/')
                        {
                            part2 = part1 / cl;
                            if (czyt[5] == '*' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '*') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '/')
                            {
                                if ((part2 / dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 / dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '-')
                    {
                         part1 = al - bl;
                         if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                         if (czyt[3] == '*')
                         {
                             part2 = part1 * cl;
                             if (czyt[5] == '*' || czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatorów!");
                             if (czyt[5] == '/')
                             {
                                 if ((part2 / dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                 if ((part2 / dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                             }

                         }
                         if (czyt[3] == '/')
                         {
                             part2 = part1 / cl;
                             if (czyt[5] == '-' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                             if (czyt[5] == '*')
                             {
                                 if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                 if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                             }
                         }
                    }

                    break;

                case 36:
                    Console.WriteLine("4 4 8 8; operatory + - *");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '*') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }

                    break;

                case 42:
                    Console.WriteLine("2 3 6 6; operatory + * *");
                    Console.WriteLine("W tym przypadku można użyć operatora '*' dwa razy.");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatora '+'!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatora '+'!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;

                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatora '+'!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }

                    break;

                case 45:
                    Console.WriteLine("2 6 6 8; operatory / * -");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '/')
                    {
                        part1 = al / bl;
                        if (czyt[3] == '/') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '/')
                        {
                            part2 = part1 / cl;
                            if (czyt[5] == '*' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '*') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '/')
                            {
                                if ((part2 / dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 / dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                        if (czyt[1] == '-')
                        {
                            part1 = al - bl;
                            if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                            if (czyt[3] == '*')
                            {
                                part2 = part1 * cl;
                                if (czyt[5] == '*' || czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatorów!");
                                if (czyt[5] == '/')
                                {
                                    if ((part2 / dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                    if ((part2 / dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                                }

                            }
                            if (czyt[3] == '/')
                            {
                                part2 = part1 / cl;
                                if (czyt[5] == '-' || czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatorów!");
                                if (czyt[5] == '*')
                                {
                                    if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                    if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                                }
                            }
                        }
                    }

                    break;

                case 24:
                    Console.WriteLine("2 4 4 8; operatory - * *");
                    Console.WriteLine("W tym przypadku można użyć operatora '*' dwa razy.");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatora '-'!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatora '-'!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;

                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatora '-'!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }

                    break;

                case 30:
                    Console.WriteLine("2 2 5 6; operatory / * *");
                    Console.WriteLine("W tym przypadku można użyć operatora '*' dwa razy.");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '/')
                    {
                        part1 = al / bl;
                        if (czyt[3] == '/') Console.WriteLine("Nie można powtarzać operatora '/'!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatora '/'!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;

                        if (czyt[3] == '/')
                        {
                            part2 = part1 / cl;
                            if (czyt[5] == '/') Console.WriteLine("Nie można powtarzać operatora '/'!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '/')
                            {
                                if ((part2 / dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 / dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                    }

                    break;

                case 40:
                    Console.WriteLine("1 6 8 9; operatory + - *");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '*') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }

                    break;

                case 50:
                    Console.WriteLine("2 5 7 9; operatory + - *");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '*') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }

                    break;

                case 35:
                    Console.WriteLine("1 6 7 8; operatory + - *");
                    czyt = Console.ReadLine().ToCharArray(0, 7);
                    a = czyt[0]; al = (int)(a - '0');
                    b = czyt[2]; bl = (int)(b - '0');
                    c = czyt[4]; cl = (int)(c - '0');
                    d = czyt[6]; dl = (int)(d - '0');

                    if (czyt[1] == '+')
                    {
                        part1 = al + bl;
                        if (czyt[3] == '+') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '*')
                    {
                        part1 = al * bl;
                        if (czyt[3] == '*') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '*' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '-')
                            {
                                if ((part2 - dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 - dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '-')
                        {
                            part2 = part1 - cl;
                            if (czyt[5] == '-' || czyt[5] == '*') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
                        }
                    }
                    if (czyt[1] == '-')
                    {
                        part1 = al - bl;
                        if (czyt[3] == '-') Console.WriteLine("Nie można powtarzać operatorów!");

                        if (czyt[3] == '*')
                        {
                            part2 = part1 * cl;
                            if (czyt[5] == '*' || czyt[5] == '-') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '+')
                            {
                                if ((part2 + dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 + dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }

                        }
                        if (czyt[3] == '+')
                        {
                            part2 = part1 + cl;
                            if (czyt[5] == '-' || czyt[5] == '+') Console.WriteLine("Nie można powtarzać operatorów!");
                            if (czyt[5] == '*')
                            {
                                if ((part2 * dl) == wynik) Console.WriteLine("Gratulacje! To prawidłowe działanie.");
                                if ((part2 * dl) != wynik) Console.WriteLine("Spróbuj jeszcze raz :(");
                            }
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
