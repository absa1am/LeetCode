using System.Collections.Generic;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int x = target - nums[i];
            if(d.ContainsKey(x)) return new int[] {i, d[x]};
            else d.TryAdd(nums[i], i);
        }

        return new int[] {};
    }
}