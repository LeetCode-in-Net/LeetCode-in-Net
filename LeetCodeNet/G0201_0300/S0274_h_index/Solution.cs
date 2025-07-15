namespace LeetCodeNet.G0201_0300.S0274_h_index {

// #Medium #Array #Sorting #Counting_Sort #Top_Interview_150_Array/String
// #2025_07_15_Time_0_ms_(100.00%)_Space_41.48_MB_(96.76%)

public class Solution {
    public int HIndex(int[] citations) {
        int len = citations.Length;
        int[] freqArray = new int[len + 1];
        foreach (int citation in citations) {
            freqArray[Math.Min(citation, len)]++;
        }
        int totalSoFar = 0;
        for (int k = len; k >= 0; k--) {
            totalSoFar += freqArray[k];
            if (totalSoFar >= k) {
                return k;
            }
        }
        return 0;
    }
}
}
