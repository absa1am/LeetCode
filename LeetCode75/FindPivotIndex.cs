public class FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int idx = -1;
        int[] preSum = new int[nums.Length + 2];

        preSum[0] = 0;
        preSum[1] = nums[0];
        preSum[nums.Length] = 0;

        for(int i = 2; i < preSum.Length - 1; i++)
            preSum[i] = preSum[i - 1] + nums[i - 1];

        for(int i = 1; i < preSum.Length - 1; i++)
        {
            int leftSum = preSum[i - 1] - preSum[0];
            int rightSum = preSum[preSum.Length - 2] - preSum[i];

            if(leftSum == rightSum) return i - 1;
        }
        
        return idx;
    }
}