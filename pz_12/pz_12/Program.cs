namespace pz_12;
class Program
{
    /*Реализуйте метод GetMax поиска наибольшего числа из произвольного количества чисел.
            Использовать в качестве параметра массив целых чисел и выходной параметр maxValue*/
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 564, -453, 536456, 546, 1111111 };
        int maxValue;
        GetMax(array, out maxValue);
        Console.WriteLine(maxValue);
    }
    static int GetMax(int[] a, out int maxValue)
    {
        maxValue = a.Max();
        return maxValue;
    }
}