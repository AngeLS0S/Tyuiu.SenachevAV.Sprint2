using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SenachevAV.Sprint2.Task2.V7.Lib
{
    public class DataService : ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool f = true; 

            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 13))
            {
                if ((x == 3) && (y >= 3) && (y <= 7) && (y == 11))
                {
                    return f = true;
                }
                if ((x == 4) && ( y >= 3) && (y <= 13))
                {
                    return f = true;
                }
                if ((x == 5) && (y >=3) && (y <= 13))
                {
                    return f = true;
                }
                if ((x == 6) && (y >= 5) && (y <= 8) && (y >= 12) && (y <= 13))
                {
                    return f = true;
                }
                if ((x == 7) && (y >= 5) && (y <= 8))
                {
                    return f = true;
                }
                if ((x == 8) && (y >= 5) && (y <= 8))
                {
                    return f = true;
                }
                if ((x == 9) && (y >= 3) && (y <= 8))
                {
                    return f = true;
                }
                if ((x == 10) && (y >= 3) && (y <= 12))
                {
                    return f = true;
                }
                if ((x == 11) && (y >= 3) && (y <= 11))
                {
                    return f = true;
                }
                if ((x == 12) && (y >= 3) && (y <= 11))
                {
                    return f = true;
                }
                if ((x == 13) && (y >= 6) && (y <= 8))
                {
                    return f = true;
                }

            } 
            else
            {
                return false;
            }
            return true;
        }
    }
}
