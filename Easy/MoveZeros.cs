public class MoveZerosSolution
{
    public void MoveZeroes(int[] nums)
    {
        for(int i = 0, j = 0; i < nums.Length; i++)
        {
            if(nums[j] != 0)
            {
                nums[i] = nums[j];
                if(i != j) nums[j] = 0;
                i++;
            }
        }
    }
}