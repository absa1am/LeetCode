using System.Text;

public class FindTheDifferenceSolution
{
    public char FindTheDifference(string s, string t)
    {
        int m = 0, n = 0;

        byte[] sm = Encoding.ASCII.GetBytes(s);
        byte[] tn = Encoding.ASCII.GetBytes(t);

        for(int i = 0; i < sm.Length; i++)
            m += sm[i];

        for(int i = 0; i < tn.Length; i++)
            n += tn[i];

        return (char) (n - m);
    }
}