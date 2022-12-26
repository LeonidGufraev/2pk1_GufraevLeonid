namespace pz_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.С помощью рекурсии вычислите n-й член арифметической прогрессии, значения первого
элемента a1 и шаг d.
            Вариант 4. a1 = 100, d = 10*/

            Console.WriteLine("Введите порядковый номер члена арифметической прогрессии");
            int n = Convert.ToInt32(Console.ReadLine());
            int a1 = 100;
            void RecursionProgression(int n)
            {
                int d = 10;
                if (n != 1)
                {
                    a1 = a1 + d;
                    n--;
                    RecursionProgression(n);
                }
            }
            RecursionProgression(n);
            Console.WriteLine("Ответ: " + a1 + "\n\n");


            /*2.С помощью рекурсии вычислить n-й член геометрической прогрессии, значения первого
элемента b1 и знаменатель прогрессии q
            Вариант 4. b1 - 4, q - 0,1*/

            Console.WriteLine("Введите порядковый номер члена геометрической прогрессии");
            int m = Convert.ToInt32(Console.ReadLine());
            double b1 = 4;
            void GeoProg()
            {
                double q = 0.1;
                if (m != 1)
                {
                    b1 = b1 * q;
                    m--;
                    GeoProg();
                }

            }
            GeoProg();
            Console.WriteLine("Ответ: " + b1 + "\n\n");
            /*3. Даны два целых числа A и В (каждое в отдельной строке). Выведите все числа от A до B
включительно, используя рекурсию, в порядке возрастания, если A < B, или в порядке
убывания в противном случае*/
            Console.WriteLine("Введите число A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            int p = 0;
            if (A < B)
            {
                p = B - A;
                res = B - 1;
            }
            else if (B < A)
            {
                p = A - B;
                res = A - 1;
            }
            void AB()
            {
                if (p != 1)
                {
                    Console.WriteLine("Результат: " + res);
                    res--;
                    p--;
                    AB();
                }
            }
            AB();
        }
    }
}