public class FirstUniqueCharacterInAStringSolution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, (int p, int v)> letters = new();

        for(int i = 0; i < s.Length; i++)
        {
            if(!letters.ContainsKey(s[i])) letters.Add(s[i], (i, 1));
            else letters[s[i]] = (letters[s[i]].p, letters[s[i]].v + 1);
        }

        foreach(char k in letters.Keys)
            if(letters[k].v == 1) return letters[k].p;

        return -1;
    }
}