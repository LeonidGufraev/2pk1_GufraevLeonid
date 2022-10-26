//Вариант 4

int a = Convert.ToInt32(Console.ReadLine());
float b = Convert.ToSingle(Console.ReadLine());
double m, n, k;
if (b > 10.5)
    n = (38 * a )/ (13 * (a - b));
else
    n = 12 * Math.Cos(0.1*b);
if (n <= 2)
    m = Math.Sin(a * Math.Pow(n, 2));
else
    m = 21*a*n+2.5* Math.Pow(n, 2);
k = Math.Pow((a + n), 4) + Math.Pow((b + m), 2);
Console.Write($"a = {a}, b = {b}, m = {m}, n = {n}, k = {k}");