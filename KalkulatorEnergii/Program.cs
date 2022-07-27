/*

Kalkulator Energi. Zlicza Ilośc zuzytej energi.
CZas trwania , i koszt.

*/

using KalkulatorEnergii;

var kalk = new KalkulatorEnergi();



bool wartownik = true;
do
{

    Console.WriteLine(@"Jeżeli chcesz podać własne dane - Wcisnij 'y' <Enter>. 
Dane default wciśnij 'n' <Enter>. 
Zakończ wciśnij 'q' <Enter>.");
    string wyborUzytkownika = Console.ReadLine();

    switch (wyborUzytkownika)

    {
        case "n":

            Console.Clear();
            Console.WriteLine(kalk.inforamcje());
            Console.ReadKey();
            wartownik = false;
            break;
        case "q":
            wartownik = false;
            break;

        case "y":
            Console.Clear();
            Console.WriteLine("Podaj cene usługi np. '0,74'");
            kalk.cena_uslugi = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj przeszły odczyt licznika");
            kalk.licznik_od = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj odczyt licznika aktualny");
            kalk.licznik_do = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj jednostkę np. 'kwh'");
            kalk.jednostka = Console.ReadLine();

            Console.WriteLine("Podaj date od kiedy '2022,6,1");
            string datkaOd = Console.ReadLine();
            kalk.data_od = datkaOd;

            Console.WriteLine("Podaj date do kiedy '2022,7,1");
            string datkaDo = Console.ReadLine();
            kalk.data_do = datkaDo;

            Console.WriteLine(kalk.inforamcje());
            Console.ReadKey();
            wartownik = false;
            break;

        default:
            Console.WriteLine("Musisz wpisać 'y', albo 'n' albo 'q'");

            break;

    }



} while (wartownik);


