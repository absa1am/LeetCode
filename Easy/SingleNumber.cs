public class SingleNumberSolution
{
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, int> d = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if(d.ContainsKey(nums[i])) d[nums[i]]++;
            else d.Add(nums[i], 1);
        }

        for(int i = 0; i < nums.Length; i++)
            if(d[nums[i]] == 1) return nums[i];

        return 0;
    }
}