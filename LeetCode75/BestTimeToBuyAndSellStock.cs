public class BestTimeToBuyAndSellStockSolution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int price = prices[0];
        
        for(int i = 1; i < prices.Length; i++)
        {
            if(price < prices[i]) profit = Math.Max(profit, prices[i] - price);
            else price = prices[i];
        }

        return profit;
    }
}