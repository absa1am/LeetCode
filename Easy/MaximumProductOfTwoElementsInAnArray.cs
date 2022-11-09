public class MaximumProductOfTwoElementsInAnArraySolution
{
    public int MaxProduct(int[] nums)
    {
        int m = 0, n = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(n < nums[i])
            {
                m = n;
                n = nums[i];
            }
            else if(m < nums[i]) m = nums[i];
        }

        return (m - 1) * (n - 1);
    }
}