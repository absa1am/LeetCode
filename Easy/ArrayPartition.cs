public class ArrayPartitionSolution
{
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);

        int maxPairSum = 0;
        for(int i = nums.Length - 2; i >= 0; i -= 2)
            maxPairSum += nums[i];

        return maxPairSum;
    }
}