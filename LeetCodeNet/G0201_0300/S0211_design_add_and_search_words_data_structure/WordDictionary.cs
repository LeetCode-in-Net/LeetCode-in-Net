namespace LeetCodeNet.G0201_0300.S0211_design_add_and_search_words_data_structure {

// #Medium #String #Depth_First_Search #Design #Trie #Top_Interview_150_Trie
// #2025_07_14_Time_380_ms_(93.39%)_Space_147.60_MB_(63.66%)

public class WordDictionary {
    private class Node {
        public Node[] kids = new Node[26];
        public bool isTerminal;
    }

    private readonly Node[] root = new Node[26];

    public WordDictionary() {
        // empty constructor
    }

    public void AddWord(string word) {
        int n = word.Length;
        if (root[n] == null) {
            root[n] = new Node();
        }
        Node node = root[n];
        for (int i = 0; i < n; i++) {
            int c = word[i] - 'a';
            Node kid = node.kids[c];
            if (kid == null) {
                kid = new Node();
                node.kids[c] = kid;
            }
            node = kid;
        }
        node.isTerminal = true;
    }

    public bool Search(string word) {
        Node node = root[word.Length];
        return node != null && Dfs(0, node, word);
    }

    private bool Dfs(int i, Node node, string word) {
        int len = word.Length;
        if (i == len) {
            return false;
        }
        char c = word[i];
        if (c == '.') {
            foreach (Node kid in node.kids) {
                if (kid == null) {
                    continue;
                }
                if ((i == len - 1 && kid.isTerminal) || Dfs(i + 1, kid, word)) {
                    return true;
                }
            }
            return false;
        }
        Node next = node.kids[c - 'a'];
        if (next == null) {
            return false;
        }
        if (i == len - 1) {
            return next.isTerminal;
        }
        return Dfs(i + 1, next, word);
    }
}
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
