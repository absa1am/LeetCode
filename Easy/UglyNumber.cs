public class UglyNumberSolution
{
    public bool IsUgly(int n)
    {
        if(n == 1) return true;
        
        for(int i = 2; i <= 5; i++)
            while(n % i == 0 && n > 0) n /= i;

        return n == 1? true:false;
    }
}