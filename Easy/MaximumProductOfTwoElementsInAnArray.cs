public class MaximumProductOfTwoElementsInAnArraySolution
{
    public int MaxProduct(int[] nums)
    {
        Array.Sort(nums, new Comparison<int>((a, b) => b.CompareTo(a)));

        return (nums[0] - 1) * (nums[1] - 1);
    }
}