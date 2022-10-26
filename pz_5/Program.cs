//Вариант 4
Console.WriteLine($"\nTask 1");
//Диапазон 0..70, шаг 2
for (int x = 0; x <= 70; x+=2)
{
    Console.WriteLine(x);
}
Console.WriteLine($"\nTask 2");
//symbol d, n = 6
char symbol = 'd';
for (byte y = 1; y<= 6; y++)
{
    Console.WriteLine(symbol);
    symbol++;
}
Console.WriteLine($"\nTask 3"); ;
//n(char) = 5, m(str) = 5
char a = '#';
for(int m = 1; m <= 5; m++)
{
    for (byte n = 1; n <= 5; n++)
    {
        Console.Write(a);
    }
    Console.Write("\n");
}
Console.WriteLine($"\nTask 4");
//7
for (byte z = 0; z<=100; z++)
{
    if (z % 7 == 0)
        Console.WriteLine(z);
    else
    {
    }
}
Console.WriteLine($"\nTask 5");
//i=2,j=40,r=25
for (int i = 2, j = 40; j-i>25;i++, --j)
{
    Console.WriteLine($"j-i = {j} - {i} = {j-i}");
}
