// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
int liczba_wlosowana = rnd.Next(1, 11);

int licznik_prob = 0;

Console.WriteLine("Została wylosowana liczba z zakresu od 1 do 10");
Console.WriteLine("Zgadnij jaka to liczba !");
Console.WriteLine("Podaj liczbę:");

string typUzytkownikaStr = Console.ReadLine();
int typUzytkownikaInt = int.Parse(typUzytkownikaStr);

bool wartownik_petli = true;
while (wartownik_petli)
{



    if (typUzytkownikaInt == liczba_wlosowana)
    {
        Console.WriteLine($"Zgadłeś !! Liczba prób wynosi {licznik_prob}");
        wartownik_petli = false;
    }


    else if (typUzytkownikaInt > liczba_wlosowana)
    {
        Console.WriteLine("Liczba jest za duża");
    }
    else
    {
        Console.WriteLine("Liczba jest za mała");
    }
    if (wartownik_petli)
    {
        Console.WriteLine("Podaj liczbę:");
        typUzytkownikaStr = Console.ReadLine();

        typUzytkownikaInt = int.Parse(typUzytkownikaStr);

    }
    licznik_prob++;
}

Console.ReadKey();