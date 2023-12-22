namespace LeetCodeNet.G0001_0100.S0006_zigzag_conversion {

// #Medium #String #2023_12_22_Time_59_ms_(99.87%)_Space_45.1_MB_(74.68%)

using System.Text;

public class Solution {
    public string Convert(string s, int numRows) {
        int sLen = s.Length;
        if (numRows == 1) {
            return s;
        }
        int maxDist = numRows * 2 - 2;
        StringBuilder buf = new StringBuilder();
        for (int i = 0; i < numRows; i++) {
            int index = i;
            if (i == 0 || i == numRows - 1) {
                while (index < sLen) {
                    buf.Append(s[index]);
                    index += maxDist;
                }
            } else {
                while (index < sLen) {
                    buf.Append(s[index]);
                    index += maxDist - i * 2;
                    if (index >= sLen) {
                        break;
                    }
                    buf.Append(s[index]);
                    index += i * 2;
                }
            }
        }
        return buf.ToString();
    }
}
}
