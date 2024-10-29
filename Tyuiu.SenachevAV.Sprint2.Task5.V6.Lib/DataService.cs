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
                case (1, 6):
                    res = "Шестёрка пик";
                    break;
                case (2, 6):
                    res = "Шестёрка треф";
                    break;
                case (3, 6):
                    res = "Шестёрка бубен";
                    break;
                case (4, 6):
                    res = "Шестёрка червей";
                    break;

                case (1, 7):
                    res = "Семёрка пик";
                    break;
                case (2, 7):
                    res = "Семёрка треф";
                    break;
                case (3, 7):
                    res = "Семёрка бубен";
                    break;
                case (4, 7):
                    res = "Семёрка червей";
                    break;

                case (1, 8):
                    res = "Восьмёрка пик";
                    break;
                case (2, 8):
                    res = "Восьмёрка треф";
                    break;
                case (3, 8):
                    res = "Восьмёрка бубен";
                    break;
                case (4, 8):
                    res = "Восьмёрка червей";
                    break;

                case (1, 9):
                    res = "Девятка пик";
                    break;
                case (2, 9):
                    res = "Девятка треф";
                    break;
                case (3, 9):
                    res = "Девятка бубен";
                    break;
                case (4, 9):
                    res = "Девятка червей";
                    break;

                case (1, 10):
                    res = "Десятка пик";
                    break;
                case (2, 10):
                    res = "Десятка треф";
                    break;
                case (3, 10):
                    res = "Десятка бубен";
                    break;
                case (4, 10):
                    res = "Десятка червей";
                    break;

                case (1, 11):
                    res = "Валет пик";
                    break;
                case (2, 11):
                    res = "Валет треф";
                    break;
                case (3, 11):
                    res = "Валет бубен";
                    break;
                case (4, 11):
                    res = "Валет червей";
                    break;

                case (1, 12):
                    res = "дама пик";
                    break;
                case (2, 12):
                    res = "Дама треф";
                    break;
                case (3, 12):
                    res = "Дама бубен";
                    break;
                case (4, 12):
                    res = "Дама червей";
                    break;

                case (1, 13):
                    res = "Король пик";
                    break;
                case (2, 13):
                    res = "Король треф";
                    break;
                case (3, 13):
                    res = "Король бубен";
                    break;
                case (4, 13):
                    res = "Король червей";
                    break;

                case (1, 14):
                    res = "Туз пик";
                    break;
                case (2, 14):
                    res = "Туз треф";
                    break;
                case (3, 14):
                    res = "Туз бубен";
                    break;
                case (4, 14):
                    res = "Туз червей";
                    break;

                default:
                    throw new ArgumentException($"Первое число должно быть от 1 - 4, второе число от 6 - 14: Значение {value1}{value2}");
            }
            return res;
        }
    }
}
