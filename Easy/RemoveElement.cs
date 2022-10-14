public class RemoveElementSolution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i, k = nums.Length - 1;
        
        if(k == -1) return 0;
        
        for(i = 0; i < nums.Length; i++)
        {
            if(nums[i] == val && k > i)
            {
                while(k > i)
                {
                    if(nums[k] != val)
                    {
                        nums[i] = nums[k];
                        nums[k] = val;
                        break;
                    }

                    k--;
                }
            }
        }

        return (nums[k] != val)? k + 1:k;
    }
}