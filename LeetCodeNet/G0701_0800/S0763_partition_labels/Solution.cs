namespace LeetCodeNet.G0701_0800.S0763_partition_labels {

// #Medium #Top_100_Liked_Questions #String #Hash_Table #Greedy #Two_Pointers
// #Data_Structure_II_Day_7_String #Big_O_Time_O(n)_Space_O(1)
// #2025_06_16_Time_2_ms_(86.67%)_Space_46.51_MB_(87.11%)

using System.Collections.Generic;

public class Solution {
    public IList<int> PartitionLabels(string s) {
        char[] letters = s.ToCharArray();
        IList<int> result = new List<int>();
        int[] position = new int[26];
        for (int index = 0; index < letters.Length; index++) {
            position[letters[index] - 'a'] = index;
        }
        int i = 0;
        int prev = -1;
        int max = 0;
        while (i < letters.Length) {
            if (position[letters[i] - 'a'] > max) {
                max = position[letters[i] - 'a'];
            }
            if (i == max) {
                result.Add(i - prev);
                prev = i;
            }
            i++;
        }
        return result;
    }
}
}
