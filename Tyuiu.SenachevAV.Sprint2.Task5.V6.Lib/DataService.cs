using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SenachevAV.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res;
            switch (value1, value2)
            {
                case (6, 1):
                    res = "Шестёрка пик";
                    break;
                case (6, 2):
                    res = "Шестёрка треф";
                    break;
                case (6, 3):
                    res = "Шестёрка бубен";
                    break;
                case (6, 4):
                    res = "Шестёрка червей";
                    break;

                case (7, 1):
                    res = "Семёрка пик";
                    break;
                case (7, 2):
                    res = "Семёрка треф";
                    break;
                case (7, 3):
                    res = "Семёрка бубен";
                    break;
                case (7, 4):
                    res = "Семёрка червей";
                    break;

                case (8, 1):
                    res = "Восьмёрка пик";
                    break;
                case (8, 2):
                    res = "Восьмёрка треф";
                    break;
                case (8, 3):
                    res = "Восьмёрка бубен";
                    break;
                case (8, 4):
                    res = "Восьмёрка червей";
                    break;

                case (9, 1):
                    res = "Девятка пик";
                    break;
                case (9, 2):
                    res = "Девятка треф";
                    break;
                case (9, 3):
                    res = "Девятка бубен";
                    break;
                case (9, 4):
                    res = "Девятка червей";
                    break;

                case (10, 1):
                    res = "Десятка пик";
                    break;
                case (10, 2):
                    res = "Десятка треф";
                    break;
                case (10, 3):
                    res = "Десятка бубен";
                    break;
                case (10, 4):
                    res = "Десятка червей";
                    break;

                case (11, 1):
                    res = "Валет пик";
                    break;
                case (11, 2):
                    res = "Валет треф";
                    break;
                case (11, 3):
                    res = "Валет бубен";
                    break;
                case (11, 4):
                    res = "Валет червей";
                    break;

                case (12, 1):
                    res = "Дама пик";
                    break;
                case (12, 2):
                    res = "Дама треф";
                    break;
                case (12, 3):
                    res = "Дама бубен";
                    break;
                case (12, 4):
                    res = "Дама червей";
                    break;

                case (13, 1):
                    res = "Король пик";
                    break;
                case (13, 2):
                    res = "Король треф";
                    break;
                case (13, 3):
                    res = "Король бубен";
                    break;
                case (13, 4):
                    res = "Король червей";
                    break;

                case (14, 1):
                    res = "Туз пик";
                    break;
                case (14, 2):
                    res = "Туз треф";
                    break;
                case (14, 3):
                    res = "Туз бубен";
                    break;
                case (14, 4):
                    res = "Туз червей";
                    break;

                default:
                    throw new ArgumentException($"Первое число должно быть от 6 - 14, второе число от 1 - 4: Значение {value1}{value2}");
            }
            return res;
        }
    }
}
