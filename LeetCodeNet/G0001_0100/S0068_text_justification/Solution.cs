namespace LeetCodeNet.G0001_0100.S0068_text_justification {

// #Hard #Array #String #Simulation #Top_Interview_150_Array/String
// #2025_07_02_Time_1_ms_(83.99%)_Space_47.93_MB_(33.99%)

public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var res = new List<string>();
        int i = 0;
        int n = words.Length;
        while (i < n) {
            int j = i, lineLen = 0;
            while (j < n && lineLen + words[j].Length + (j - i) <= maxWidth) {
                lineLen += words[j].Length;
                j++;
            }
            int spaces = maxWidth - lineLen;
            int gaps = j - i - 1;
            var line = new System.Text.StringBuilder();
            if (j == n || gaps == 0) {
                for (int k = i; k < j; k++) {
                    line.Append(words[k]);
                    if (k < j - 1) {
                        line.Append(' ');
                    }
                }
                line.Append(' ', maxWidth - line.Length);
            } else {
                int spaceEach = spaces / gaps;
                int extra = spaces % gaps;
                for (int k = i; k < j; k++) {
                    line.Append(words[k]);
                    if (k < j - 1) {
                        line.Append(' ', spaceEach + (k - i < extra ? 1 : 0));
                    }
                }
            }
            res.Add(line.ToString());
            i = j;
        }
        return res;
    }
}
}
