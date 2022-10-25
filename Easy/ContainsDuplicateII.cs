public class ContainsDuplicateIISolution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> d = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if(!d.ContainsKey(nums[i])) d.Add(nums[i], i);
            else if(i - d[nums[i]] <= k) return true;
            else d[nums[i]] = i;
        }

        return false;
    }
}