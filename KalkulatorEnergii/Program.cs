/*

Kalkulator Energi. Zlicza Ilośc zuzytej energi.
CZas trwania , i koszt.

*/



KalkulatorEnergii kalk = new KalkulatorEnergii();



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





class KalkulatorEnergii
{

    public double cena_uslugi;
    public double licznik_od;
    public double licznik_do;
    public string jednostka;


    public string data_od;
    public string data_do;

    public DateTime dataOd;
    public DateTime dataDo;

    public string[] dataOdString;
    public string[] dataDoString;
    public KalkulatorEnergii(string data_od = "2022, 6, 1", 
                             string data_do = "2022, 7, 26", 
                             double cena_uslugi = 0.74, 
                             double licznik_od = 5788 + 236, 
                             double licznik_do = 6433.4, 
                             string jednostka = "kwh")
    {
        this.cena_uslugi = cena_uslugi;
        this.licznik_od = licznik_od;
        this.licznik_do = licznik_do;
        this.jednostka = jednostka;
        this.data_od = data_od;
        this.data_do = data_do;

    }



    public int CzasUzytkownika()

    {
        dataOdString = data_od.Split(',');
        dataDoString = data_do.Split(',');
        dataOd = new DateTime(int.Parse(dataOdString[0]), int.Parse(dataOdString[1]), int.Parse(dataOdString[2]));
        dataDo = new DateTime(int.Parse(dataDoString[0]), int.Parse(dataDoString[1]), int.Parse(dataDoString[2]));
        var roznica = dataDo - dataOd;
        return roznica.Days;

    }

    public double Zużycie()
    {


        return Math.Round((licznik_do - licznik_od), 2);

    }

    public double Koszt()
    {

        return Math.Round((cena_uslugi * Zużycie()), 2);


    }

    public double ŚredniaJedenDzien()
    {
        return Math.Round((Zużycie() / CzasUzytkownika()), 2);

    }

    public double KosztJendegoDnia()
    {
        return Math.Round((Zużycie() / CzasUzytkownika() * cena_uslugi), 2);
    }

    public string inforamcje()
    {

        return @$"Przez {CzasUzytkownika()} dni zuzyto {Zużycie()} {jednostka}.
Koszt wynosi {Koszt()} zł przy cenie {cena_uslugi} gr.
Średnia zuzycia przez jeden dzień wynosi {ŚredniaJedenDzien()}{jednostka} 
Koszt jednego dnia jest równy: {KosztJendegoDnia()}zł przy średniej {ŚredniaJedenDzien()}{jednostka}";

    }




}

