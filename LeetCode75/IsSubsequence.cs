public class IsSubsequenceSolution
{
    public bool IsSubsequence(string s, string t)
    {
        int i, k = 0;
        for(i = 0; i < s.Length; i++)
        {
            bool found = false;

            while(k < t.Length)
            {
                if(s[i] == t[k])
                {
                    found = true;
                    k++;
                    break;
                }
                k++;
            }

            if(!found) return false;
        }
        
        return (i == s.Length && k <= t.Length);
    }
}