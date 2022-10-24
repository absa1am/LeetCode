public class MoveZerosSolution
{
    public void MoveZeroes(int[] nums)
    {
        for(int i = 0, j = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                j = i + 1;
                while(j < nums.Length)
                {
                    if(nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                    j++;
                }

                if(j >= nums.Length) break;
            }
        }
    }
}