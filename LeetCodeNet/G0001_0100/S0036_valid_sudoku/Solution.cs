namespace LeetCodeNet.G0001_0100.S0036_valid_sudoku {
    
// #Medium #Top_Interview_Questions #Array #Hash_Table #Matrix #Data_Structure_I_Day_5_Array
// #Top_Interview_150_Matrix #2025_06_30_Time_1_ms_(98.25%)_Space_48.16_MB_(85.00%)

using System.Collections.Generic;

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rows = new bool[9, 9];
        bool[,] cols = new bool[9, 9];
        bool[,] blocks = new bool[9, 9];
        for (int i = 0; i < board.Length; i++) {
            for (int j = i; j < board[i].Length; j++) {
                if (!isValidCase(board, i: i, j: j, rows: rows, cols: cols, blocks: blocks)) {
                    return false;
                }
                if (i != j && !isValidCase(board, i: j, j: i, rows: rows, cols: cols, blocks: blocks)) {
                    return false;
                }
            }
        }
        return true;
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822", Justification = "LeetCode")]
    private bool isValidCase(char[][] board, int i, int j, bool[,] rows, bool[,] cols, bool[,] blocks) { // NOSONAR
        if (board[i][j] == '.') {
            return true;
        }
        int num = board[i][j] - '1';
        int block = (i / 3) * 3 + (j / 3);
        if (rows[i, num] || cols[j, num] || blocks[block, num]) {
            return false;
        }
        rows[i, num] = true;
        cols[j, num] = true;
        blocks[block, num] = true;
        return true;
    }
}
}