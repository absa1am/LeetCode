using System.Collections;

public class IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        int n = s.Length;
        string a = string.Empty;
        Hashtable h = new Hashtable();
        Hashtable h1 = new Hashtable();

        for(int i = 0; i < n; i++)
        {
            if(!h.ContainsKey(s[i]) && !h1.ContainsKey(t[i]))
            {
                a += t[i];
                h.Add(s[i], t[i]);
                h1.Add(t[i], s[i]);
            }
            else if(h[s[i]] != h1[t[i]]) a += h[s[i]];
            else a += h1[s[i]];
        }
        
        return a == t;
    }
}