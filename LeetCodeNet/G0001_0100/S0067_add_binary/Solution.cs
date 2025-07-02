namespace LeetCodeNet.G0001_0100.S0067_add_binary {

// #Easy #String #Math #Bit_Manipulation #Simulation #Programming_Skills_II_Day_5
// #Top_Interview_150_Bit_Manipulation #2025_07_02_Time_1_ms_(91.47%)_Space_41.80_MB_(61.20%)

public class Solution {
    public string AddBinary(string a, string b) {
        var sb = new System.Text.StringBuilder();
        int i = a.Length - 1; 
        int j = b.Length - 1; 
        int carry = 0;
        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry;
            if (i >= 0) {
                sum += a[i--] - '0';
            }
            if (j >= 0) {
                sum += b[j--] - '0';
            }
            sb.Insert(0, (char)('0' + (sum % 2)));
            carry = sum / 2;
        }
        return sb.ToString();
    }
}
}
