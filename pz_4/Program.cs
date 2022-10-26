/*Вариант 2*
Составить программу, которая по заданному году и номеру месяца m
определяет количество дней в этом месяце. Задавать год необходимо
для того, чтобы определить високосный ли год. (Год високосный,
если он делится на четыре без остатка, но если он делится на 100 без
остатка, это не високосный год. Однако, если он делится без остатка
на 400, это високосный год. Таким образом, 2000 г. является особым
високосным годом, который бывает лишь раз в 400 лет.)
*/
Console.WriteLine("Введите год: ");
int y = Convert.ToInt16(Console.ReadLine()); //year
Console.WriteLine("Введите месяц: ");
byte m = Convert.ToByte(Console.ReadLine()); //month
byte a; //Костыли, для определения кол-ва дней в феврале
if (y % 400 == 0)// условие, чтобы узнать, високосный ли год
{
    Console.WriteLine($"{y} год - високосный");
    a = 29;
}
else if (y % 100 == 0)
{
    Console.WriteLine($"{y} год не високосный");
    a = 28;
}
else if (y % 4 == 0)
{
    Console.WriteLine($"{y} год - високосный");
    a = 29;
}
else
{
    Console.WriteLine($"{y} год не високосный");
    a = 28;
}

switch (m) //switch, чтобы узнать, сколько дней во введенном пользователем месяце
{
    case 1:
        Console.WriteLine($"В {m}-ом месяце 31 день");
        break;
    case 2:
        Console.WriteLine($"Во {m}-ом месяце {a} дней");
        break;
    case 3:
        Console.WriteLine($"В {m}-ем месяце 31 день");
        break;
    case 4:
        Console.WriteLine($"В {m}-ом месяце 30 дней");
        break;
    case 5:
        Console.WriteLine($"В {m}-ом месяце 31 день");
        break;
    case 6:
        Console.WriteLine($"В {m}-ом месяце 30 дней");
        break;
    case 7:
        Console.WriteLine($"В {m}-ом месяце 31 день");
        break;
    case 8:
        Console.WriteLine($"В {m}-ом месяце 31 день");
        break;
    case 9:
        Console.WriteLine($"В {m}-ом месяце 30 дней");
        break;
    case 10:
        Console.WriteLine($"В {m}-ом месяце 31 день");
        break;
    case 11:
        Console.WriteLine($"В {m}-ом месяце 30 дней");
        break;
    case 12:
        Console.WriteLine($"В {m}-ом месяце 31 день");
        break;
    default:
        Console.WriteLine("Данные введены неверно");
        break;
}
   