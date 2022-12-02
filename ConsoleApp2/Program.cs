int[,] myArray;
myArray = new int[8, 8];

Console.WriteLine("KING MOVES");
Console.WriteLine("Type X");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Type Y");
int y = int.Parse(Console.ReadLine());
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 8; j++)
    {
        myArray[i, j] = 0;

    }
}

{
    myArray[x, y] = 1;
    myArray[x + 1, y + 1] = 2;
    myArray[x + 1, y + 0] = 3;
    myArray[x + 1, y + 1] = 4;
    myArray[x + 0, y - 1] = 5;
    myArray[x + 0, y + 1] = 6;
    myArray[x-1, y-1] = 7;
    myArray[x-1, y + 0] = 8;
    myArray[x-1,  y + 1] = 9;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            Console.Write(myArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}



