public class NumberOfCommonFactorsSolution
{
    public int CommonFactors(int a, int b)
    {
        int nf = 0;
        for(int i = 1; i <= Math.Min(a, b); i++)
            if(a % i == 0 && b % i == 0) nf++;

        return nf;
    }
}