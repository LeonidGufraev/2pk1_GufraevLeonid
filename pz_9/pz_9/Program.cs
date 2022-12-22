namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание:
            1.создать ступенчатый массив в соответствии со своим вариантом.Длину второго
            измерения генерировать рандомно в соответствии с вариантом.Заполнить массив
            нужными значениями(способ заполнения рандом или расчет по произвольной
            формуле).
Вариант 4; Тип данных массива - char;  Длина первого
измерения = 9; Длина второго = 10..35
            2.Вывести сгенерированный массив в консоль(каждая строка отдельно, элементы
            разделены визуально)*/
            Random znach = new Random();
            char[][] arr = new char[9][];
            char[] arr1 = new char[9];
            char[] arrmax = new char[9];
            int[] arrnd = new int[9];
            char[][] arrinverse = new char[9][];
            int a;
            Console.WriteLine("Изначальный вывод массива:");
            for (int b = 0; b < 9; b++)
            {
                a = znach.Next(10, 36);
                arrnd[b] = a;
                arr[b] = new char[a];
                for (int j = 0; j < a; j++)
                {
                    arr[b][j] = (char)znach.Next('a', '{');
                    Console.Write(arr[b][j] + " ");
                    if (j == arr[b].Length - 1) //условие считывание последнего элемента строки зубчатого массива
                    {
                        arr1[b] = arr[b][j];
                    }
                }
                Console.WriteLine();
            }
            /*
             3.Создать новый одномерный массив и записать в него последние элементы каждой
             строки.Вывести данный массив.*/
            Console.WriteLine("\n\nПоследние элементы каждой строки:");
            foreach (char i in arr1)
            {
                Console.Write(i + " ");
            }
            for (int b = 0; b < 9; b++)//Цикл для присваивания элементу массива наибольшеее значение из строки зубчатого маасива
            {
                arrmax[b] = arr[b].Max();
            }
            /*
             4.В каждой строке найти максимальный элемент, записать их в другой массив(новый
             или повторно использовать предыдущий) и вывести его содержимое.
             */
            Console.WriteLine("\n\nНаибольший элемент каждой строки зубчатого массива:");
            foreach (char i in arrmax)
            {
                Console.Write(i + " ");
            }
            /*
             5.В каждой строке исходного массива поменять местами первый элемент и
             максимальный в строке. Вывести обновленный массив.*/
            Console.WriteLine("\n\nПеремена мест 1 элемента и наибольшего:");
            for (int b = 0; b < 9; b++)
            {
                for (int j = 0; j < arrnd[b]; j++)
                {
                    if (j == 0)
                    {
                        int maxindex = Array.IndexOf(arr[b], arrmax[b]);
                        arr[b][maxindex] = arr[b][0];
                        arr[b][0] = arrmax[b];
                    }
                    Console.Write(arr[b][j] + " ");
                }
                Console.WriteLine();
            }
            /*
              6.Выполнить реверс каждой строки ступенчатого массива
             */
            Console.WriteLine("\n\nИнверсия массива:");
            for (int b = 0; b < 9; b++)
            {
                int k = arrnd[b] - 1;
                arrinverse[b] = new char[arrnd[b]];
                for (int j = 0; j < arrnd[b]; j++)
                {
                    arrinverse[b][j] = arr[b][k];
                    k--;
                    Console.Write(arrinverse[b][j] + " ");
                }
                Console.WriteLine();
            }
            /*
             7.Подсчитать:
 c.Наиболее встречающиеся символы в каждой строке ступенчатого массива
 (для символов)
         */
            Console.WriteLine("\n\nНаиболее встречающиеся символы:");
            char[] sb = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int b = 0; b < 9; b++)
            {
                int[] sbs = new int[26];
                for (int d = 0; d < 26; d++)
                {
                    int t = 0;
                    for (int j = 0; j < arrnd[b]; j++)
                    {
                        if (sb[d] == arr[b][j])
                        {
                            t++;
                        }
                    }
                    sbs[d] = t;
                }
                int maxValue = sbs.Max();
                int g = Array.IndexOf(sbs, maxValue);//В итоге, если есть 2+ часто встречаемых символов, мы получаем тот, который первым идет в алфавите
                Console.WriteLine(sb[g]);
            }
        }
    }
}