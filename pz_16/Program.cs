namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4 Дан файл, в котором текст содержится в специальном формате (трехзначный индекс, сумма в
формате XXXX.XX): 001 0253.55 Количество строк не более 50. Произвести анализ текста
и вывести общую сумму*/
            Random rnd = new Random();
            int a = rnd.Next(0, 51);
            double res = 0.0;
            FileStream file = new FileStream(@"D:\file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamWriter writer = new StreamWriter(file))
            {
                for (int i = 0; i < a; i++)
                {
                    int b = rnd.Next();
                    double c = rnd.NextDouble();
                    string e = string.Format("{0:f2}", c);
                    e = e.Substring(2);
                    double d = Convert.ToDouble(e);
                    writer.WriteLine(b + "," + e); //Я не смог привести данную строку к нужному типу, поэтому использовал запятую
                }
            }
            file.Close();
            FileStream file2 = new FileStream(@"D:\file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamReader reader = new StreamReader(file2))
            {
                for (int j = 0; j < a; j++)
                {
                    double read = Convert.ToDouble(reader.ReadLine());
                    res += read;
                    Console.WriteLine(res);
                }
            }
            file2.Close();
        }
    }
}