using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MasalimovTR.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            startValue =1 ; stopValue =1;
            return [-15.6, -12.35, -10.72, -8.88, -2.16, 3.25, 6.64, 10.3, 16.17, 28.1, 38.41];
        }
    }
}
