public class AverageSalaryExcludingTheMinimumAndMaximumSalarySolution
{
    public double Average(int[] salary)
    {
        int min = 1000000;
        int max = 1000;
        
        for(int i = 0; i < salary.Length; i++)
        {
            if(salary[i] < min) min = salary[i];
            if(salary[i] > max) max = salary[i];
        }
        
        double avg = 0.0;
        for(int i = 0; i < salary.Length; i++)
            if(salary[i] != min && salary[i] != max)
                avg += salary[i];
        
        return avg / (salary.Length - 2);
    }
}