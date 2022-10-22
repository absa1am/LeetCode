public class PowerOfTwoSolution
{
    public bool IsPowerOfTwo(int n)
    {
        long p = 1;
        
        for(int i = 1; p <= (long) n; i++)
        {
            if(p == (long) n) return true;
            p = p * 2;
        }
        
        return false;
    }
}