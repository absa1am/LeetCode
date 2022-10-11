public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = string.Empty;

        int min = 200;
        for(int i = 0; i < strs.Length; i++)
            if(strs[i].Length < min) min = strs[i].Length;

        for(int i = 0; i < min; i++)
        {
            for(int j = 1; j < strs.Length; j++)
                if(strs[0][i] != strs[j][i]) return prefix;

            prefix += strs[0][i].ToString();
        }

        return prefix;
    }
}