namespace LeetCodeNet.G0201_0300.S0211_design_add_and_search_words_data_structure {

using Xunit;

public class WordDictionaryTest {
    [Fact]
    public void WorldDataStructure() {
        string[] input = {"bad", "dad", "mad"};
        var dictionary = new WordDictionary();
        foreach (var s in input) {
            dictionary.AddWord(s);
        }
        Assert.False(dictionary.Search("pad"));
        Assert.True(dictionary.Search("bad"));
        Assert.True(dictionary.Search(".ad"));
        Assert.True(dictionary.Search("b.."));
    }
}
}
