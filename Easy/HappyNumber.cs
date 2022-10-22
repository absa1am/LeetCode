public class HappyNumberSolution {
    public bool IsHappy(int n)
    {
        if(n == 1) return true;
        if(n <= 3) return false;
        
        int c = 0;
        while(n != 1)
        {
            c = c + 1;
            n = GetSquaredSum(n);
            if(c > 750) return false;
        }
        
        return true;
    }
    
    public int GetSquaredSum(int n)
    {
        int sum = 0;
        
        while(n > 0)
        {
            sum += (n % 10) * (n % 10);
            n /= 10;
        }
        
        return sum;
    }
}