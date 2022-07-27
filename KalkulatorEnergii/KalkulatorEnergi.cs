namespace KalkulatorEnergii;

public class KalkulatorEnergi
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
    public KalkulatorEnergi(string data_od = "2022, 6, 1", 
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

