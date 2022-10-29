public class ReverseVowelsOfAStringSolution
{
    public string ReverseVowels(string s)
    {
        char[] str = s.ToCharArray();

        for(int i = 0, j = str.Length - 1; i < j; i++)
        {
            if(IsVowel(str[i]))
            {
                while(j > i)
                {
                    if(IsVowel(str[j])) break;
                    j--;
                }

                char c = str[i];
                str[i] = str[j];
                str[j] = c;
                j--;
            }
        }

        return new string(str);
    }

    public bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}