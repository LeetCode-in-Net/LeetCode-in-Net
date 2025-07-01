namespace LeetCodeNet.G0001_0100.S0052_n_queens_ii {

// #Hard #Backtracking #Top_Interview_150_Backtracking
// #2025_07_01_Time_1_ms_(95.31%)_Space_29.22_MB_(64.06%)

public class Solution {
    public int TotalNQueens(int n) {
        int count = 0;
        Solve(0, n, new bool[n], new bool[2 * n], new bool[2 * n], ref count);
        return count;
    }

    private void Solve(int row, int n, bool[] cols, bool[] d1, bool[] d2, ref int count) {
        if (row == n) {
            count++;
            return;
        }
        for (int col = 0; col < n; col++) {
            int id1 = col - row + n;
            int id2 = col + row;
            if (cols[col] || d1[id1] || d2[id2]) continue;
            cols[col] = d1[id1] = d2[id2] = true;
            Solve(row + 1, n, cols, d1, d2, ref count);
            cols[col] = d1[id1] = d2[id2] = false;
        }
    }
}
}
