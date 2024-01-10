namespace LeetCodeNet.G0201_0300.S0208_implement_trie_prefix_tree {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #String #Hash_Table #Design #Trie
// #Level_2_Day_16_Design #Udemy_Trie_and_Heap
// #Big_O_Time_O(word.length())_or_O(prefix.length())_Space_O(N)
// #2024_01_10_Time_178_ms_(88.12%)_Space_133.5_MB_(9.47%)

public class Trie {
    private TrieNode root;
    private bool startWith;

    private class TrieNode {
        // Initialize your data structure here.
        public TrieNode[] children;
        public bool isWord;

        public TrieNode() {
            children = new TrieNode[26];
        }
    }

    public Trie() {
        root = new TrieNode();
    }

    // Inserts a word into the trie.
    public void Insert(string word) {
        Insert(word, root, 0);
    }

    private void Insert(string word, TrieNode root, int idx) {
        if (idx == word.Length) {
            root.isWord = true;
            return;
        }
        int index = word[idx] - 'a';
        if (root.children[index] == null) {
            root.children[index] = new TrieNode();
        }
        Insert(word, root.children[index], idx + 1);
    }

    // Returns if the word is in the trie.
    public bool Search(string word) {
        return Search(word, root, 0);
    }

    private bool Search(string word, TrieNode root, int idx) {
        if (idx == word.Length) {
            startWith = true;
            return root.isWord;
        }
        int index = word[idx] - 'a';
        if (root.children[index] == null) {
            startWith = false;
            return false;
        }
        return Search(word, root.children[index], idx + 1);
    }

    // Returns if there is any word in the trie
    // that starts with the given prefix.
    public bool StartsWith(string prefix) {
        Search(prefix);
        return startWith;
    }
}
/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
}
