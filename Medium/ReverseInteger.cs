public class ReverseIntegerSolution
{
    public int Reverse(int n)
    {
        int rn = n % 10;

        n /= 10;
        while(n != 0)
        {
            if((((long) rn * 10 <= (long) int.MaxValue &&
            (long) rn * 10 >= (long) int.MinValue)) ||
            (((long) rn * 10 + (long) n % 10) <= (long) int.MaxValue) &&
            (((long) rn * 10 + (long) n % 10) >= (long) int.MinValue))
            {
                rn = rn * 10 + n % 10;
                n /= 10;
            }
            else return 0;
        }

        return rn;
    }
}