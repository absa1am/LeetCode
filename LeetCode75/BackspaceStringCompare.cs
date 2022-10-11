public class BackspaceStringCompareSolution
{
    public bool BackspaceCompare(string s, string t)
    {
        Stack<char> a = new Stack<char>();
        Stack<char> b = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '#') a.TryPop(out char c);
            else a.Push(s[i]);
        }

        for(int i = 0; i < t.Length; i++)
        {
            if(t[i] == '#') b.TryPop(out char c);
            else b.Push(t[i]);
        }

        return string.Join(' ', a) == string.Join(' ', b);
    }
}