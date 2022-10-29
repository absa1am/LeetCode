public class MissingNumberSolution
{
    public int MissingNumber(int[] nums)
    {
        bool[] exist = new bool[nums.Length + 1];
        
        for(int i = 0; i < nums.Length; i++)
            exist[nums[i]] = true;
        
        for(int i = 0; i < exist.Length; i++)
            if(!exist[i]) return i;
        
        return 0;
    }
}