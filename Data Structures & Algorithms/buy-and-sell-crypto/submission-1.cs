public class Solution {//REVISION
    public int MaxProfit(int[] prices) {
        int maxProfit=0;
        int minBuy=prices[0];
        for(int i=1;i<prices.Length;i++)
        {
            maxProfit=Math.Max(maxProfit,prices[i]-minBuy);
            minBuy=Math.Min(minBuy,prices[i]);
        }
        return maxProfit;
    }
}
