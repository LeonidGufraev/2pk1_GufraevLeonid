namespace pz_13
{
    internal class Program
    {
        /*4 Реализуйте метод, принимающий в качестве параметра строку, содержащую ФИО студента в
полном формате (“иванов иван иванович”). Метод возвращает обновленную строку, с
фамилией с заглавной буквой и инициалами: “Иванов И.И.”
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО в полном формате");
            string fio= Console.ReadLine();
            string fio2;
            GetFIO(fio, out fio2);
            Console.WriteLine(fio2);
        }
        static string GetFIO(string fio, out string fio2)
        {
            int a1 = fio.IndexOf(" ");
            int a2 = fio.LastIndexOf(" ");
            string str = fio.Substring(1, a1);
            string str1 = fio.Substring(a1+1, a2);
            string str2 = fio.Substring(a2+1);
            string str3 = fio.Substring(0, 1);
            str3 = str3.ToUpper();
            str1 = str1.Remove(1);
            str2 = str2.Remove(1);
            str1 = str1 +'.';
            str2 = str2 + '.';
            fio2 = str3 + str + str1.ToUpper() + str2.ToUpper();
            return (fio2);
        }
    }
}