namespace LeetCodeNet.G0201_0300.S0208_implement_trie_prefix_tree {

using Xunit;

public class TrieTest {
    [Fact]
    public void Trie() {
        Trie trie = new Trie();
        trie.Insert("apple");
        // return True
        Assert.True(trie.Search("apple"));
        // return False
        Assert.False(trie.Search("app"));
        // return True
        Assert.True(trie.StartsWith("app"));
        trie.Insert("app");
        // return True
        Assert.True(trie.Search("app"));
    }
}
}
