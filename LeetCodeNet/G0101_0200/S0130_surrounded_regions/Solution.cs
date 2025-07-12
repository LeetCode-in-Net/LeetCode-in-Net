namespace LeetCodeNet.G0101_0200.S0130_surrounded_regions {

// #Medium #Top_Interview_Questions #Array #Depth_First_Search #Breadth_First_Search #Matrix
// #Union_Find #Algorithm_II_Day_8_Breadth_First_Search_Depth_First_Search
// #Top_Interview_150_Graph_General #2025_07_12_Time_1_ms_(100.00%)_Space_64.38_MB_(92.86%)

public class Solution {
    public void Solve(char[][] board) {
        if (board.Length == 0) {
            return;
        }
        for (int i = 0; i < board[0].Length; i++) {
            if (board[0][i] == 'O') {
                Dfs(board, 0, i);
            }
            if (board[board.Length - 1][i] == 'O') {
                Dfs(board, board.Length - 1, i);
            }
        }
        for (int i = 0; i < board.Length; i++) {
            if (board[i][0] == 'O') {
                Dfs(board, i, 0);
            }
            if (board[i][board[0].Length - 1] == 'O') {
                Dfs(board, i, board[0].Length - 1);
            }
        }
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                if (board[i][j] == 'O') {
                    board[i][j] = 'X';
                }
                if (board[i][j] == '#') {
                    board[i][j] = 'O';
                }
            }
        }
    }

    private void Dfs(char[][] board, int row, int column) {
        if (row < 0 || row >= board.Length || column < 0 || column >= board[0].Length || board[row][column] != 'O') {
            return;
        }
        board[row][column] = '#';
        Dfs(board, row + 1, column);
        Dfs(board, row - 1, column);
        Dfs(board, row, column + 1);
        Dfs(board, row, column - 1);
    }
}
}
