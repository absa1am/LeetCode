public class ExcelSheetColumnNumberSolution
{
    public int TitleToNumber(string columnTitle)
    {
        int p, columnNumber = 0;
        Dictionary<char, int> d = new();

        p = 1;
        for(char k = 'A'; k <= 'Z'; k++)
            d.Add(k, p++);

        p = 1;
        for(int i = columnTitle.Length - 1; i >= 0; i--)
        {
            columnNumber += d[columnTitle[i]] * p;
            p *= 26;
        }

        return columnNumber;
    }
}