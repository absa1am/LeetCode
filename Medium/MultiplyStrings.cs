public class MultiplyStringsSolution
{
    public string Multiply(string num1, string num2)
    {
        if(num1.Length < num2.Length)
        {
            string t = num1;
            num1 = num2;
            num2 = t;
        }

        if(num1 == "0" || num2 == "0") return "0";

        char[] r = new char[250];
        for(int i = 0; i < 250; i++) r[i] = '0';

        int j, carry = 0;
        for(int b = num2.Length - 1, i = 0; b >= 0; b--, i++)
        {
            j = i;
            carry = 0;
            for(int a = num1.Length - 1; a >= 0; a--)
            {
                int x = carry + (r[j] - '0') + ((num1[a] - '0') * (num2[b] - '0'));
                r[j++] = (char) ((x % 10) + 48);
                carry = x / 10;
            }

            if(carry > 0) r[j] = (char) (carry + 48);
        }

        Array.Reverse(r);

        return new string(r).TrimStart('0');
    }
}