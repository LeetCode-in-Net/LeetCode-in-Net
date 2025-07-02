namespace LeetCodeNet.G0001_0100.S0030_substring_with_concatenation_of_all_words {

// #Hard #String #Hash_Table #Sliding_Window #Top_Interview_150_Sliding_Window
// #2025_06_30_Time_15_ms_(94.14%)_Space_57.94_MB_(46.58%)

using System.Collections.Generic;

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var res = new List<int>();
        if (string.IsNullOrEmpty(s) || words == null || words.Length == 0) {
            return res;
        }
        int wordLen = words[0].Length;
        int numWords = words.Length;
        int totalLen = wordLen * numWords;
        if (s.Length < totalLen) {
            return res;
        }
        var wordCount = new Dictionary<string, int>();
        foreach (var word in words) {
            if (wordCount.ContainsKey(word)) {
                wordCount[word]++;
            } else {
                wordCount[word] = 1;
            }
        }
        for (int i = 0; i < wordLen; i++) {
            int left = i;
            int count = 0;
            var seenWords = new Dictionary<string, int>();
            for (int j = i; j <= s.Length - wordLen; j += wordLen) {
                string word = s.Substring(j, wordLen);
                if (wordCount.ContainsKey(word)) {
                    if (seenWords.ContainsKey(word)) {
                        seenWords[word]++;
                    } else {
                        seenWords[word] = 1;
                    }
                    if (seenWords[word] <= wordCount[word]) {
                        count++;
                    } else {
                        while (seenWords[word] > wordCount[word]) {
                            string leftWord = s.Substring(left, wordLen);
                            seenWords[leftWord]--;
                            if (seenWords[leftWord] < wordCount[leftWord]) {
                                count--;
                            }
                            left += wordLen;
                        }
                    }
                    if (count == numWords) {
                        res.Add(left);
                        string leftWord = s.Substring(left, wordLen);
                        seenWords[leftWord]--;
                        count--;
                        left += wordLen;
                    }
                } else {
                    seenWords.Clear();
                    count = 0;
                    left = j + wordLen;
                }
            }
        }
        return res;
    }
}
}
