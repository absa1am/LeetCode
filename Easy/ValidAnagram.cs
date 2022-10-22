public class ValidAnagramSolution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> d = new();

        for(int i = 0; i < s.Length; i++)
        {
            if(!d.ContainsKey(s[i])) d.Add(s[i], 1);
            else d[s[i]]++;
        }

        for(int i = 0; i < t.Length; i++)
        {
            if(!d.ContainsKey(t[i])) return false;
            else d[t[i]]--;
        }

        foreach(char k in d.Keys)
            if(d[k] != 0) return false;

        return true;
    }
}