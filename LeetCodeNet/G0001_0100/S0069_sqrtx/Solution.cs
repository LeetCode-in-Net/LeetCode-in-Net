namespace LeetCodeNet.G0001_0100.S0069_sqrtx {

// #Easy #Top_Interview_Questions #Math #Binary_Search #Binary_Search_I_Day_4
// #Top_Interview_150_Math #2025_07_04_Time_0_ms_(100.00%)_Space_29.30_MB_(44.18%)

public class Solution {
    public int MySqrt(int x) {
        if (x < 2) {
            return x;
        }
        int left = 1;
        int right = x / 2;
        int ans = 0;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if ((long)mid * mid == x) {
                return mid;
            }
            if ((long)mid * mid < x) {
                ans = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return ans;
    }
}
}
