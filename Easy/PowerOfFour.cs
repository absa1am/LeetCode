public class PowerOfFourSolution
{
    public bool IsPowerOfFour(int n)
    {
        long x = 1;
        while(x * 4 <= n) x *= 4;

        return x == (long) n;
    }
}