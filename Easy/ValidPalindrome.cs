public class ValidPalindromeSolution
{
    public bool IsPalindrome(string s)
    {
        string str = string.Empty;

        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsLetterOrDigit(s[i]))
                str += s[i].ToString().ToLower();
        }

        for(int i = 0, j = str.Length - 1; i < j; i++, j--)
            if(str[i] != str[j]) return false;
        
        return true;
    }
}