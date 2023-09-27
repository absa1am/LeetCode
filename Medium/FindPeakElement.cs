public class FindPeakElementSolution
{
    public int FindPeakElement(int[] nums)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l < r)
        {
            int a = l + (r - l) / 2;
            int b = a + 1;
            
            if (nums[a] < nums[b]) l = b;
            else r = a;
        }

        return l;
    }
}