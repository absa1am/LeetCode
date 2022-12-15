public class MinimumOperationsToMakeTheArrayIncreasingSolution
{
    public int MinOperations(int[] nums) {
        int maxOperation = 0;
        int len = nums.Length;
        for(int i = 1; i < len; i++)
        {
            if(nums[i - 1] == nums[i])
            {
                nums[i]++;
                maxOperation++;
            }
            else if(nums[i - 1] > nums[i])
            {
                maxOperation += nums[i - 1] - nums[i] + 1;
                nums[i] += nums[i - 1] - nums[i] + 1;
                
            }
        }

        return maxOperation;
    }
}