// See https://aka.ms/new-console-template for more information


int[] lista_liczb = new int[23];
int[] lista_indexow = {0,1,2,3,4,5,6,7,8,9,10};

// foreach(var i in lista_indexow)
// {
//     Console.WriteLine(lista_liczb[i]);
// }


int[][] multiDimension = new int[2][];
multiDimension[0] = new int[4];
multiDimension[1] = new int[3];

multiDimension[0][0] = 4;
multiDimension[0][1] = 4;
multiDimension[0][2] = 4;
multiDimension[0][3] = 4;
multiDimension[1][0] = 11;
multiDimension[1][1] = 22;
multiDimension[1][2] = 33;
Console.WriteLine(multiDimension[0].Length);

for(int i = 0; i < multiDimension.Length; i++)
{

    for(int j = 0; j < multiDimension[i].Length; j++){

        Console.WriteLine(multiDimension[i][j]);
    }
}