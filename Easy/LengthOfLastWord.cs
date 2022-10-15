public class LengthOfLastWordSolution
{
    public int LengthOfLastWord(string s)
    {
        int len = 0;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            if(char.IsLetter(s[i]))
            {
                while(i >= 0)
                {
                    if(char.IsLetter(s[i])) len++;
                    else break;
                    i--;
                }

                return len;
            }
        }

        return len;
    }
}