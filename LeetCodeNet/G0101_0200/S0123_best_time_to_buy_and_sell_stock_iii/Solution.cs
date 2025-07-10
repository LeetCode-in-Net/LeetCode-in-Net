namespace LeetCodeNet.G0101_0200.S0123_best_time_to_buy_and_sell_stock_iii {

// #Hard #Array #Dynamic_Programming #Top_Interview_150_Multidimensional_DP
// #2025_07_10_Time_3_ms_(86.18%)_Space_63.38_MB_(69.12%)

public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) {
            return 0;
        }
        int fb = int.MinValue;
        int sb = int.MinValue;
        int fs = 0;
        int ss = 0;
        foreach (int price in prices) {
            fb = System.Math.Max(fb, -price);
            fs = System.Math.Max(fs, fb + price);
            sb = System.Math.Max(sb, fs - price);
            ss = System.Math.Max(ss, sb + price);
        }
        return ss;
    }
}
}
