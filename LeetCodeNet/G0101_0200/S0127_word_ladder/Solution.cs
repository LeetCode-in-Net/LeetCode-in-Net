namespace LeetCodeNet.G0101_0200.S0127_word_ladder {

// #Hard #Top_Interview_Questions #String #Hash_Table #Breadth_First_Search
// #Graph_Theory_I_Day_12_Breadth_First_Search #Top_Interview_150_Graph_BFS
// #2025_07_09_Time_22_ms_(96.00%)_Space_45.97_MB_(83.68%)

using System.Collections.Generic;

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordDict) {
        var beginSet = new HashSet<string>();
        var endSet = new HashSet<string>();
        var wordSet = new HashSet<string>(wordDict);
        var visited = new HashSet<string>();
        if (!wordDict.Contains(endWord)) {
            return 0;
        }
        int len = 1;
        int strLen = beginWord.Length;
        beginSet.Add(beginWord);
        endSet.Add(endWord);
        while (beginSet.Count > 0 && endSet.Count > 0) {
            if (beginSet.Count > endSet.Count) {
                var temp = beginSet;
                beginSet = endSet;
                endSet = temp;
            }
            var tempSet = new HashSet<string>();
            foreach (var s in beginSet) {
                char[] chars = s.ToCharArray();
                for (int i = 0; i < strLen; i++) {
                    char old = chars[i];
                    for (char j = 'a'; j <= 'z'; j++) {
                        chars[i] = j;
                        string temp = new string(chars);
                        if (endSet.Contains(temp)) {
                            return len + 1;
                        }
                        if (!visited.Contains(temp) && wordSet.Contains(temp)) {
                            tempSet.Add(temp);
                            visited.Add(temp);
                        }
                    }
                    chars[i] = old;
                }
            }
            beginSet = tempSet;
            len++;
        }
        return 0;
    }
}
}
