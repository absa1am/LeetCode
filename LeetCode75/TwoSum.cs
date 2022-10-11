public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> d = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if(!d.ContainsKey(target - nums[i])) d.TryAdd(nums[i], i);
            else return new int[] {d[target - nums[i]], i};
        }

        return new int[] {};
    }
}