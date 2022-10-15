public class AddBinarySolution
{
    public string AddBinary(string a, string b)
    {
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        string bin = string.Empty;

        int r = 0;
        while(aLen >= 0 || bLen >= 0)
        {
            int p, q;

            if(aLen >= 0) p = int.Parse(a[aLen].ToString());
            else p = 0;

            if(bLen >= 0) q = int.Parse(b[bLen].ToString());
            else q = 0;

            int n = p + q + r;

            bin += (n % 2).ToString();
            r = n / 2;

            aLen--; bLen --;
        }

        if(r != 0) bin += r.ToString();

        char[] charBin = bin.ToCharArray();
        Array.Reverse(charBin);
        
        return new string(charBin);
    }
}