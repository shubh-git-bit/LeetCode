public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int maxProfit = 0;
        int profit = 0;
        int cheapest = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            profit = prices[i] - cheapest;
            maxProfit = Math.Max(profit, maxProfit);
            cheapest = Math.Min(cheapest, prices[i]);
        }

        return maxProfit;
    }
}