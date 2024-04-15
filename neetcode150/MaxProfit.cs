public class Solution {
    public int MaxProfit(int[] prices) {
        int min=prices[0];
        int profit = 0;
        if(prices.Length==0){return 0;}//caso base
        for(int i = 0;i<prices.Length;i++){
            profit = Math.Max(profit,prices[i]-min);
            min= Math.Min(min,prices[i]);
        }
        return profit;
        
    }
}