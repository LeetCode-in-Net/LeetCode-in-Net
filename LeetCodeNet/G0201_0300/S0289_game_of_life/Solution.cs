namespace LeetCodeNet.G0201_0300.S0289_game_of_life {

// #Medium #Array #Matrix #Simulation #Top_Interview_150_Matrix
// #2025_07_16_Time_0_ms_(100.00%)_Space_46.31_MB_(66.67%)

public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length, n = board[0].Length;
        int[] dx = {0, 0, 1, 1, 1, -1, -1, -1};
        int[] dy = {1, -1, 0, 1, -1, 0, 1, -1};
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int live = 0;
                for (int d = 0; d < 8; d++) {
                    int ni = i + dx[d], nj = j + dy[d];
                    if (ni >= 0 && ni < m && nj >= 0 && nj < n && (board[ni][nj] & 1) == 1) live++;
                }
                if ((board[i][j] & 1) == 1) {
                    if (live == 2 || live == 3) board[i][j] |= 2;
                } else {
                    if (live == 3) board[i][j] |= 2;
                }
            }
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                board[i][j] >>= 1;
            }
        }
    }
}
}
