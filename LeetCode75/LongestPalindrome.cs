public class LongestPalindromeSolution
{
    public int LongestPalindrome(string s)
    {
        int ans = 0;
        bool found = false;
        Dictionary<char, int> d = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(d.ContainsKey(s[i])) d[s[i]]++;
            else d.Add(s[i], 1);
        }

        foreach(KeyValuePair<char, int> item in d)
        {
            if(item.Value % 2 == 0) ans += item.Value;
            else
            {
                found = true;
                ans += item.Value - 1;
            }
        }

        if(found) ans++;

        return ans;
    }
}