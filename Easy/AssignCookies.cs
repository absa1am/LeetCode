public class AssignCookiesSolution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        int i = 0, j = 0, ans = 0;
        while(i < g.Length && j < s.Length)
        {
            if(g[i] > s[j]) j++;
            else {
                ans++;
                i++;
                j++;
            }
        }

        return ans;
    }
}