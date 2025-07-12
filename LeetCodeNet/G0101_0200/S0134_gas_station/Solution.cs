namespace LeetCodeNet.G0101_0200.S0134_gas_station {

// #Medium #Top_Interview_Questions #Array #Greedy #Top_Interview_150_Array/String
// #2025_07_12_Time_0_ms_(100.00%)_Space_70.56_MB_(58.80%)

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int index = 0;
        int total = 0;
        int current = 0;
        for (int i = 0; i < gas.Length; i++) {
            int balance = gas[i] - cost[i];
            total += balance;
            current += balance;
            if (current < 0) {
                index = i + 1;
                current = 0;
            }
        }
        return total >= 0 ? index : -1;
    }
}
}
