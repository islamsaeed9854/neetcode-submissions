public class Solution {
    public int MaxProfit(int[] prices) {
        int mx = 0 , mn  = 1221;
        for(int i= 0 ; i< prices.Length; i++){
            mx = Math.Max(mx , prices[i] - mn);
            mn = Math.Min (mn , prices[i]);
        }
        return mx;
    }
}
