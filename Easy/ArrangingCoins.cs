public class ArrangingCoinsSolution
{
    public int ArrangeCoins(int n)
    {
        int ans = 0;
        while(n >= 0) n -= ++ans;

        return ans - 1;
    }
}