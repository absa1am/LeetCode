public class MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        int sum = 0;
        int ans = int.MinValue;

        for(int i = 0; i < nums.Length; i++)
        {
            sum = Math.Max(nums[i], sum + nums[i]);
            ans = Math.Max(ans, sum);
        }
        
        return ans;
    }
}