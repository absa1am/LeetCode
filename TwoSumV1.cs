using System.Collections;

public class TwoSumSolutionV1
{
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable h = new Hashtable();

        for(int i = 0; i < nums.Length; i++)
        {
            int x = target - nums[i];
            if(h.ContainsKey(x)) return new int[] {i, (int) h[x]};
            else if(!h.ContainsKey(nums[i])) h.Add(nums[i], i);
        }

        return new int[] {};
    }
}