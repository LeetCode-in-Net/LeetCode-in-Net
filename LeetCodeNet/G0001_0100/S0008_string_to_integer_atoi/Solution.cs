namespace LeetCodeNet.G0001_0100.S0008_string_to_integer_atoi {

// #Medium #Top_Interview_Questions #String #Big_O_Time_O(n)_Space_O(n)
// #2025_06_12_Time_0_ms_(100.00%)_Space_41.82_MB_(46.21%)

public class Solution {
    public int MyAtoi(string str) {
        if (str == null || str.Length == 0) {
            return 0;
        }
        int i = 0;
        bool negetiveSign = false;
        char[] input = str.ToCharArray();
        while (i < input.Length && input[i] == ' ') {
            i++;
        }
        if (i == input.Length) {
            return 0;
        } else if (input[i] == '+') {
            i++;
        } else if (input[i] == '-') {
            i++;
            negetiveSign = true;
        }
        int num = 0;
        while (i < input.Length && input[i] <= '9' && input[i] >= '0') {
            // current char
            int tem = input[i] - '0';
            tem = negetiveSign ? -tem : tem;
            // avoid invalid number like 038
            if (num == 0 && tem == '0') {
                i++;
            } else if (num == int.MinValue / 10 && tem <= -8 || num < int.MinValue / 10) {
                return int.MinValue;
            } else if (num == int.MaxValue / 10 && tem >= 7 || num > int.MaxValue / 10) {
                return int.MaxValue;
            } else {
                num = num * 10 + tem;
                i++;
            }
        }
        return num;
    }
}
}
