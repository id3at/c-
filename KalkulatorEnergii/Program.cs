/*

Kalkulator Energi. Zlicza Ilośc zuzytej energi.
CZas trwania , i koszt.

*/


KalkulatorEnergii kalk = new KalkulatorEnergii();


bool wartownik = true;
do
{

    Console.WriteLine("Czy chcesz podać własne dane? Wcisnij 'y'. Dane default wciśnij 'n'. Zakończ wciśnij 'q'. ");
    string wyborUzytkownika = Console.ReadLine();

    switch (wyborUzytkownika)

    {
        case "n":
            
            Console.WriteLine(kalk.inforamcje());
            Console.ReadKey();
            wartownik = false;
            break;
        case "q":
            wartownik = false;
            break;

        case "y":

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
            string[] datkaOdLista = datkaOd.Split(','); 
            for (int i = 0; i < kalk.data_od.Length; i++)
            {

                kalk.data_od[i] = int.Parse(datkaOdLista[i]);
            }

            Console.WriteLine("Podaj date do kiedy '2022,7,1");
            string datkaDo = Console.ReadLine();
            string[] datkaDoLista = datkaDo.Split(','); 
            for (int i = 0; i < kalk.data_do.Length; i++)
            {

                kalk.data_do[i] = int.Parse(datkaDoLista[i]);
            }


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


    public double cena_uslugi = 0.74;
    public double licznik_od = 5788 + 236;
    public double licznik_do = 6433.4;
    public string jednostka = "kwh";


    public int[] data_od = { 2022, 6, 1 };
    public int[] data_do = { 2022, 7, 24 };

    public DateTime dataOd;
    public DateTime dataDo;




    public int CzasUzytkownika()

    {
        dataOd = new DateTime(data_od[0], data_od[1], data_od[2]);
        dataDo = new DateTime(data_do[0], data_do[1], data_do[2]);
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

        return $"Przez {CzasUzytkownika()} dni zuzyto {Zużycie()} {jednostka}.\nKoszt wynosi {Koszt()} zł przy cenie {cena_uslugi} gr.\nŚrednia zuzycia przez jeden dzień wynosi {ŚredniaJedenDzien()}{jednostka} \nKoszt jednego dnia jest równy: {KosztJendegoDnia()}zł przy średniej {ŚredniaJedenDzien()}{jednostka}\n";

    }




}

