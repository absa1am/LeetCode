public class AddDigitsSolution
{
    public int AddDigits(int num)
    {
        while(num > 9) num = GetDigitSum(num);

        return num;
    }

    public int GetDigitSum(int num)
    {
        int sum = 0;

        while(num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
}