public class RomanToIntegerSolution
{
    public int RomanToInt(string s)
    {
        Dictionary<string, int> roman = new()
        {
            {"I", 1}, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100},
            {"D", 500}, {"M", 1000}, {"IV", 4}, {"IX", 9}, {"XL", 40},
            {"XC", 90}, {"CD", 400}, {"CM", 900}
        };

        int n = 0;
        for(int i = 0; i < s.Length - 1; i++)
        {
            string sub = s[i].ToString() + s[i + 1].ToString();

            if(roman.ContainsKey(sub)) 
            {
                n += roman[sub];
                i++;
            }
            else n += roman[s[i].ToString()];
        }

        int len = s.Length;
        
        if(len == 1) n += roman[s];
        else if(!roman.ContainsKey(s[len - 2].ToString() + s[len - 1].ToString()))
            n += roman[s[len - 1].ToString()];

        return n;
    }
}