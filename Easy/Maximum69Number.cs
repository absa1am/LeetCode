public class Maximum69NumberSolution
{
    public int Maximum69Number(int num)
    {
        char[] n = num.ToString().ToCharArray();

        for(int i = 0; i < n.Length; i++)
        {
            if(n[i] == '6')
            {
                n[i] = '9';
                break;
            }
        }

        return int.Parse(new string(n));
    }
}