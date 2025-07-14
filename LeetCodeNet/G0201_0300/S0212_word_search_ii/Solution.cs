namespace LeetCodeNet.G0201_0300.S0212_word_search_ii {

// #Hard #Top_Interview_Questions #Array #String #Matrix #Backtracking #Trie #Top_Interview_150_Trie
// #2025_07_14_Time_29_ms_(100.00%)_Space_52.23_MB_(67.78%)

using System.Collections.Generic;

public class Solution {
    private Tree root;

    public IList<string> FindWords(char[][] board, string[] words) {
        if (board.Length < 1 || board[0].Length < 1) {
            return new List<string>();
        }
        root = new Tree();
        foreach (var word in words) {
            Tree.AddWord(root, word);
        }
        var collected = new List<string>();
        for (int i = 0; i < board.Length; ++i) {
            for (int j = 0; j < board[0].Length; ++j) {
                Dfs(board, i, j, root, collected);
            }
        }
        return collected;
    }

    private void Dfs(char[][] board, int i, int j, Tree cur, List<string> collected) {
        char c = board[i][j];
        if (c == '-') {
            return;
        }
        cur = cur.GetChild(c);
        if (cur == null) {
            return;
        }
        if (cur.end != null) {
            string s = cur.end;
            collected.Add(s);
            cur.end = null;
            if (cur.Len() == 0) {
                Tree.DeleteWord(root, s);
            }
        }
        board[i][j] = '-';
        if (i > 0) {
            Dfs(board, i - 1, j, cur, collected);
        }
        if (i + 1 < board.Length) {
            Dfs(board, i + 1, j, cur, collected);
        }
        if (j > 0) {
            Dfs(board, i, j - 1, cur, collected);
        }
        if (j + 1 < board[0].Length) {
            Dfs(board, i, j + 1, cur, collected);
        }
        board[i][j] = c;
    }

    // Internal Trie/Tree class
    private class Tree {
        private readonly Tree[] children = new Tree[26];
        public string? end;

        public Tree GetChild(char c) {
            return children[c - 'a'];
        }

        public int Len() {
            int count = 0;
            foreach (var child in children) {
                if (child != null) {
                    count++;
                }
            }
            return count;
        }

        public static void AddWord(Tree root, string word) {
            var node = root;
            foreach (var c in word) {
                int idx = c - 'a';
                if (node.children[idx] == null) {
                    node.children[idx] = new Tree();
                }
                node = node.children[idx];
            }
            node.end = word;
        }

        public static void DeleteWord(Tree root, string word) {
            DeleteWordHelper(root, word, 0);
        }

        private static bool DeleteWordHelper(Tree node, string word, int d) {
            if (node == null) {
                return false;
            }
            if (d == word.Length) {
                node.end = null;
            }
            else {
                int idx = word[d] - 'a';
                if (DeleteWordHelper(node.children[idx], word, d + 1)) {
                    node.children[idx] = null;
                }
            }
            if (node.end != null) {
                return false;
            }
            foreach (var child in node.children) {
                if (child != null) return false;
            }
            return true;
        }
    }
}
}
