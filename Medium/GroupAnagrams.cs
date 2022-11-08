public class GroupAnagramsSolution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> h = new();
        IList<IList<string>> ans = new List<IList<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            char[] str = strs[i].ToCharArray();

            Array.Sort(str);

            string s = new string(str);
            
            if(!h.ContainsKey(s))
                h.Add(s, new List<string>() { strs[i] });
            else h[s].Add(strs[i]);
        }

        foreach(var k in h.Keys)
            ans.Add(h[k]);

        return ans;
    }
}