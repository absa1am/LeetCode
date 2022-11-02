public class LongestSubstringWithoutRepeatingCharactersSolution
{
    public int LengthOfLongestSubstring(string s)
    {
        int len = 0, count = 0;
        Dictionary<char, int> d = new();

        for(int i = 0; i < s.Length; i++)
        {
            int j = i;
            if(!d.ContainsKey(s[j]))
            {
                while(!d.ContainsKey(s[j]))
                {
                    count++;
                    d.Add(s[j], 1);
                    
                    if(j + 1 == s.Length) break;
                    else j++;
                }

                if(len < count) len = count;
                count = 0;
                d.Clear();
            }
        }

        return len;
    }
}