public class Bubble
{
    List<double> listaDoPosortowania;

    public Bubble(List<double> listaDoPosortowania)
    {
        this.listaDoPosortowania = listaDoPosortowania;
    }
    

    public List<double> Sortic()
    {
        int wartownikPetli = 0;
        bool zamienionoMiejscami = true;

        while (wartownikPetli < listaDoPosortowania.Count - 1 && zamienionoMiejscami)
        {
            int pomocnicza = 0;
            zamienionoMiejscami = false;

            while (pomocnicza < listaDoPosortowania.Count - 1 - wartownikPetli)
            {

                if (listaDoPosortowania[pomocnicza] > listaDoPosortowania[pomocnicza + 1])

                {
                    double temp = listaDoPosortowania[pomocnicza];
                    listaDoPosortowania[pomocnicza] = listaDoPosortowania[pomocnicza + 1];
                    listaDoPosortowania[pomocnicza + 1] = temp;
                    zamienionoMiejscami = true;

                }
                pomocnicza++;

            }
            wartownikPetli++;



        }

        return  listaDoPosortowania;

    }
}
