public class MajorityElementSolution
{
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);

        int d = 0, idx = 0;
        for(int l = 0, r = 0; r < nums.Length; r++)
        {
            if(nums[l] == nums[r])
            {
                if(d < r - l + 1)
                {
                    idx = l;
                    d = r - l + 1;
                }
            } else l = r;
        }

        return nums[idx];
    }
}