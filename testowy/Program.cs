// See https://aka.ms/new-console-template for more information
using testowy;
using System.Collections;


double[] lista = new double[10] {23.7,34,3.2,5,11,123,898,2,3,5};


int wartownikPetli = 0;

while (wartownikPetli < lista.Length - 1)
{
    int pomocnicza = 0;

        while (pomocnicza < lista.Length - 1)
        {

            if (lista[pomocnicza] > lista[pomocnicza+1])

            {
                double temp = lista[pomocnicza];
                lista[pomocnicza] = lista[pomocnicza + 1];
                lista[pomocnicza + 1] = temp;

            }
        pomocnicza++;

        }
    wartownikPetli++;
    foreach(var item in lista)
    {
        System.Console.WriteLine($"{item}");
        
        
    }
    System.Console.WriteLine("\n");


}

// System.Console.WriteLine(lista[1]);
// System.Console.WriteLine(lista[2]);


// int wartownik = 5;

// List<int> mojaListaLiczb = new List<int>();
// int inputUser;


// while(wartownik > 0)

// {
//     System.Console.WriteLine("Podaj liczbę: ");
//     inputUser = int.Parse(Console.ReadLine());
    
//     if (!mojaListaLiczb.Contains(inputUser))
//         {
//         mojaListaLiczb.Add(inputUser);
//         wartownik--;
//         }
//     else
//         System.Console.WriteLine("nie dodan");


    

// }

// foreach( var item in mojaListaLiczb)
//     System.Console.WriteLine($"To Jest : {item}");


// var imie = Console.ReadLine();
// var mojaTablica = new int[imie.Count()];

// for (int i = 0; i < imie.Count(); i++)
//     mojaTablica[i] = i;


// Array.Reverse(mojaTablica);

// string odwruconeimie = "";

// foreach (var item in mojaTablica)
//     odwruconeimie += imie[item];

// System.Console.WriteLine($"{imie} odwrócone to: {odwruconeimie} ");







// List<string> mojaLista= new List<string>();


// bool wartownik = true;

// while(wartownik)
// {
//     System.Console.WriteLine("Wprowadź imie");
//     var imie = Console.ReadLine();
//     if (imie == "")
//         wartownik = false;
//     else    
//         mojaLista.Add(imie);

// }

// if (mojaLista.Count == 1)
//     System.Console.WriteLine($"Znajomy {mojaLista[0]} polubił twój post");
// else if (mojaLista.Count == 2)
//     System.Console.WriteLine($"Znajomy {mojaLista[0]}, znajomy{mojaLista[1]}  polubił twój post");
// else if (mojaLista.Count > 2)
//     System.Console.WriteLine($"Znajomy {mojaLista[0]}, znajomy {mojaLista[1]} i inni  polubili twój post");
// else
//     System.Console.WriteLine("");

// Console.ReadKey();
