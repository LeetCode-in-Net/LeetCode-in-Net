namespace LeetCodeNet.G0001_0100.S0079_word_search {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Matrix #Backtracking
// #Algorithm_II_Day_11_Recursion_Backtracking #Top_Interview_150_Backtracking
// #Big_O_Time_O(4^(m*n))_Space_O(m*n) #2024_01_05_Time_152_ms_(99.69%)_Space_42.3_MB_(26.96%)

public class Solution {
    public bool Exist(char[][] board, string word) {
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                char ch = word[0];
                if (board[i][j] == ch) {
                    if (helper(i, j, board, word, 1)) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private bool helper(int r, int c, char[][] board, string word, int count) {
        if (count == word.Length) {
            return true;
        }
        char currChar = board[r][c];
        board[r][c] = '!';
        char nextChar = word[count];

        if (r > 0 && board[r - 1][c] == nextChar) {
            if (helper(r - 1, c, board, word, count + 1)) return true;
        }
        if (r < board.Length - 1 && board[r + 1][c] == nextChar) {
            if (helper(r + 1, c, board, word, count + 1)) return true;
        }
        if (c > 0 && board[r][c - 1] == nextChar) {
            if (helper(r, c - 1, board, word, count + 1)) return true;
        }
        if (c < board[0].Length - 1 && board[r][c + 1] == nextChar) {
            if (helper(r, c + 1, board, word, count + 1)) return true;
        }
        board[r][c] = currChar;
        return false;
    }
}
}
