public class PowerOfThreeSolution
{
    public bool IsPowerOfThree(int n)
    {
        long x = 1;
        while(3 * x <= n) x *= 3;
        
        return x == (long) n;
    }
}