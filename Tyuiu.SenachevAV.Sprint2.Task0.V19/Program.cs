using Tyuiu.SenachevAV.Sprint2.Task0.V19.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 105;
        int y = 177;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.Title = "Спринт #2 | Выполнил: Сеначев А.В. | АСОиУб-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Class Math                                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович | АСОиУб-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,)        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}