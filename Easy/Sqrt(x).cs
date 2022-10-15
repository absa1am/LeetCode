public class SquareRootOfXSolution
{
    public int MySqrt(int x)
    {
        int ans = 0;

        for(int i = 1; i <= 46340; i++)
        {
            if(i * i <= x) ans = i;
            else return ans;
        }

        return ans;
    }
}