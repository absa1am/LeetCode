public class ThirdMaximumNumberSolution
{
    public int ThirdMax(int[] nums)
    {
        long a, b, c;
        
        a = b = c = long.MinValue;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(a < nums[i])
            {
                c = b;
                b = a;
                a = nums[i];
            }
            
            if(b < nums[i] && nums[i] < a)
            {
                c = b;
                b = nums[i];
            }
            
            if(c < nums[i] && nums[i] < b)
                c = nums[i];
        }
        
        return c == long.MinValue? (int) a : (int) c;
    }
}