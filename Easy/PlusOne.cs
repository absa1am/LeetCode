public class PlusOneSolution
{
    public int[] PlusOne(int[] digits)
    {
        int r = 0, len = digits.Length;

        if(digits[len - 1] + 1 > 9)
        {
            r = 1;
            digits[len - 1] = 0;

            for(int i = len - 2; i >= 0; i--)
            {
                int n = digits[i] + r;

                digits[i] = n % 10;
                r = n / 10;
            }
        }
        else digits[len - 1]++;

        if(r != 0)
        {
            int[] newDigits = new int[len + 1];

            newDigits[0] = r;
            digits.CopyTo(newDigits, 1);

            digits = newDigits;
        }

        return digits;
    }
}