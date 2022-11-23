namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4 Найти (вычислить) сумму и произведение элементов каждой строки двумерного массива
            A[5,10] заполненного вещественными числами
            */
            double[,] arr = new double[5, 10];
            Random rnd = new Random();
            double sum = 0;
            double pr = 1;
            for (int j = 0; j < 5 ; j++)
            {
                for (int i = 0; i<10; i++)
                {
                    double a = rnd.Next(-100,100) + rnd.NextDouble();
                    arr[j, i] = a;
                    sum += a;
                    pr *= a;
                }
                Console.WriteLine($"Сумма: {sum}, произведение: {pr}");
            }

        }
    }
}