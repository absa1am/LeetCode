public class WordPatternSolution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');
        Dictionary<string, char> wp = new();

        if(pattern.Length != words.Length)
            return false;
        
        for(int i = 0; i < words.Length; i++)
        {
            if(!wp.ContainsKey(words[i]) && !wp.ContainsValue(pattern[i]))
                wp.Add(words[i], pattern[i]);
            else if(!wp.ContainsKey(words[i]) || (wp.ContainsKey(words[i]) && wp[words[i]] != pattern[i]))
                return false;
        }

        return true;
    }
}