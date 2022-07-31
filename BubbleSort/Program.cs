// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Random rndNum = new Random();

Stopwatch stopwatch = new Stopwatch();
List<double> lista = new List<double>();

for (int i = 0; i < 511110; i++)
{

    lista.Add(rndNum.Next(1,100));
    
}
stopwatch.Start();
lista.Sort();
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);

// foreach (var item in lista)
// {
// Console.Write($"{item},");
// }

System.Console.WriteLine("\n");

stopwatch.Reset();

stopwatch.Start();
Bubble bubble = new Bubble(lista);
bubble.Sortic();
stopwatch.Stop();
System.Console.WriteLine(stopwatch.ElapsedMilliseconds);

// foreach (var item in bubble.Sortic())
// {
//     Console.Write($"{item},");
// }









