public class Solution {
    public int MaxProfit(int[] prices) {
      int minSellingPrice=prices[0];
      int maxProfit=0;
      for(int i=1;i<prices.Length;i++)  
      {
        minSellingPrice=Math.Min(minSellingPrice,prices[i]);
        maxProfit=Math.Max(maxProfit,prices[i]-minSellingPrice);
      }
      return maxProfit;
    }
}
