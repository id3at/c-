namespace testowy;


public class Auto
{

    public string marka { get; set; }
    public int rocznik { get; set; }
    public Auto(string marka, int rocznik)
    {
        this.marka = marka;
        this.rocznik = rocznik;
    }

    public override string ToString()
    {
        return marka;
    }


}