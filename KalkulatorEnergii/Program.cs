/*

Kalkulator Energi. Zlicza Ilośc zuzytej energi.
CZas trwania , i koszt.

*/

KalkulatorEnergii kalk = new KalkulatorEnergii();
Console.WriteLine(kalk.inforamcje());
Console.ReadKey();


class KalkulatorEnergii
{


    public double cena_uslugi = 0.74;
    public double licznik_od = 5788 + 236;
    public double licznik_do = 6433.4;
    public string jednostka = "kwh";


    public static int[] data_od = { 2022, 6, 1 };
    public static int[] data_do = { 2022, 7, 24 };
    public DateTime dataOd = new DateTime(data_od[0], data_od[1], data_od[2]);
    public DateTime dataDo = new DateTime(data_do[0], data_do[1], data_do[2]);



    public int CzasUzytkownika()
    {
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

