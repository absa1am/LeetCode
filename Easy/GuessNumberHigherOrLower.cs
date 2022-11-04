public class GuessNumberHigherOrLowerSolution
{
    public int GuessNumber(int n)
    {
        int l = 1;
        int h = n;
        
        while(l <= h)
        {
            int m = l + (h - l) / 2;

            if(guess(m) == 0) return m;
            else if(guess(m) == -1) h = m - 1;
            else l = m + 1;
        }
        
        return 0;
    }
}