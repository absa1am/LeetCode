using System.Text;

public class AddStringsSolution
{
    public string AddStrings(string num1, string num2)
    {
        StringBuilder r = new StringBuilder("");

        if(num1.Length < num2.Length)
        {
            string temp = num1;
            num1 = num2;
            num2 = temp;
        }

        int carry = 0;
        int i = num1.Length - 1;
        int j = num2.Length - 1;

        while(i >= 0)
        {
            string n1 = num1[i].ToString();
            string n2 = j >= 0? num2[j].ToString():"0";

            int x = int.Parse(n1) + int.Parse(n2) + carry;
            r.Insert(0, x % 10);
            carry = x / 10;
            i--;
            j--;
        }

        if(carry > 0) r.Insert(0, carry);

        return r.ToString();
    }
}