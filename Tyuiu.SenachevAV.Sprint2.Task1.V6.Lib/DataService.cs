using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SenachevAV.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (b > a);
            res[1] = (c == c) & (a < b);
            res[2] = (b < c) || (c < b);
            res[3] = (c > a) && (a == a);
            res[4] = !(a < b);
            res[5] = (d == d) ^ (d == d);
            return res;
        }
    }
}
