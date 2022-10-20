public class ClimbingStairsSolution
{
    public int ClimbStairs(int n)
    {
        int a = 1, b = 2, ans = 0;

        if(n == a) return a;
        if(n == b) return b;

        for(int i = 3; i <= n; i++)
        {
            ans = a + b;
            a = b;
            b = ans;
        }

        return ans;
    }
}