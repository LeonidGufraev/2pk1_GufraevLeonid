namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4 В файле input.txt записаны числа (каждое — с новой строки), их количество не превышает
100. Необходимо найти максимальное и минимальное число и записать их в файл output.txt.*/
            Random rnd = new Random();
            int a = rnd.Next(0,101);
            int res1 = 0;
            int res2 = 0;
            FileStream input = new FileStream(@"D:\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using(StreamWriter writer = new StreamWriter(input))//поток для записи
            {
                for (int i = 0; i<a; i++)
                {
                    int b = rnd.Next();
                    writer.WriteLine(b);
                }
            }
            input.Close();
            FileStream input2 = new FileStream(@"D:\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using(StreamReader reader = new StreamReader (input2))//считываем значения
            {
                int max = 2147483647;
                int min = -2147483648;
                for (int j = 0; j<a;j++)
                {
                    int c = Convert.ToInt32(reader.ReadLine());
                    if (c <max)//2 условия для присваивания значения числам
                    {
                        res1 = c;
                        max = res1;
                    }
                    if (c > min)
                    {
                        res2 = c;
                        min = res2;
                    }
                }
            }
            input2.Close();
            FileStream res = new FileStream(@"D:\output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter text = new StreamWriter(res);//ввод данных во второй файл
            text.WriteLine("Наименьшее число: " + res1);
            text.WriteLine("Наибольшее число: " + res2);
            text.Close();
            res.Close();
        }
    }
}