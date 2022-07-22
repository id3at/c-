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
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Zgadłeś !! Liczba nie udanych prób wynosi {licznik_prob}");
        wartownik_petli = false;
    }


    else if (typUzytkownikaInt > liczba_wlosowana)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Liczba jest za duża".ToUpper());
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Liczba jest za mała".ToUpper());
    }
    if (wartownik_petli)
    {
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Podaj liczbę:");
        typUzytkownikaStr = Console.ReadLine();

        typUzytkownikaInt = int.Parse(typUzytkownikaStr);

    }
    licznik_prob++;
}

Console.ReadKey();