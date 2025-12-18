using System;

public class Zadanie
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wybierz zadanie 1, 2 lub 3");
        byte zadanie = Convert.ToByte(Console.ReadLine());

        switch (zadanie)
        {
            case 1:
                {
                    double a;
                    double b;
                    byte c;
                    Console.WriteLine("Podaj pierwsza liczbe");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj druga liczbe");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj rodzaj operacji arytmetycznej 1:+ 2:- 3:* 4:/  (+, -, * lub /)");
                    c = Convert.ToByte(Console.ReadLine());

                    if (c == 1)
                    {
                        Console.WriteLine(a + b);
                    }

                    else if (c == 2)
                    {
                        Console.WriteLine(a - b);
                    }

                    else if (c == 3)
                    {
                        Console.WriteLine(a * b);
                    }

                    else if (c == 4)
                    {
                        Console.WriteLine(a / b);
                    }

                    else
                    {
                        Console.WriteLine("Blad");
                    }
                    break;
                }

            case 2:
                Console.WriteLine("Podaj kierunek Konwersji C - przelicz stopnie Celsjusza na Fahrenheita F - przelicz stopnie Fahrenheita na Celsjusze");
                string z = Console.ReadLine();

                if (z == "C")
                {
                    Console.WriteLine("Podaj ilosc stopni Celsjusza: ");
                    Console.WriteLine(Convert.ToDouble(Console.ReadLine()) * 1.8 + 32);
                }

                else if (z == "F")
                {
                    Console.WriteLine("Podaj ilosc stopni Fahrenheita: ");
                    Console.WriteLine((Convert.ToDouble(Console.ReadLine()) - 32) / 1.8);
                }

                else
                {
                    Console.WriteLine("Blad");
                }
                break;

            case 3:
                double srednia = 0;
                Console.WriteLine("Podaj ilosc ocen cyfra");
                //byte ilosc = Convert.ToByte(Console.ReadLine());
                byte wszystkie = Convert.ToByte(Console.ReadLine());

                for (byte ilosc = wszystkie; ilosc > 0; ilosc--)
                {
                    Console.WriteLine("Podaj ocene");
                    srednia = srednia + Convert.ToByte(Console.ReadLine());
                }

                Console.WriteLine(srednia / wszystkie);
                if (srednia / wszystkie >= 3)
                {
                    Console.WriteLine("Uczen zdal");
                }
                else if (srednia / wszystkie < 3)
                {
                    Console.WriteLine("Uczen nie zdal");
                }
                break;

            default:
                {
                    Console.WriteLine("Blad");
                }
                break;
        }
    }
}