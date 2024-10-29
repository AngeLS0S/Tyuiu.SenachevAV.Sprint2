using Tyuiu.SenachevAV.Sprint2.Task5.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Сеначев А.В. | АСОиУб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операция Switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУб-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
        Console.WriteLine("* требуемое значение и возвращает результат.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите номер масти: ");
        int value1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер достоинства: ");
        int value2 = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((value1 < 1) || (value1 > 4))
        {
            res = "Введено неверное значение";

            if ((value2 < 5) || (value2 > 14))
            {
                res = "Неверное значение";
            }
        }
        else
        {
            res = "Это карта: " + ds.FindCardNameAndValue(value1, value2);
        }



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();
    }
}