namespace LeetCodeNet.G0201_0300.S0212_word_search_ii {

using System.Collections.Generic;
using Xunit;

public class SolutionTest {    
    [Fact]
    public void FindWords() {
        char[][] board = {
            new[] { 'o', 'a', 'a', 'n' },
            new[] { 'e', 't', 'a', 'e' },
            new[] { 'i', 'h', 'k', 'r' },
            new[] { 'i', 'f', 'l', 'v' }
        };
        string[] words = { "oath", "pea", "eat", "rain" };
        var expected = new List<string> { "oath", "eat" };
        var result = new Solution().FindWords(board, words);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindWords2() {
        char[][] board = {
            new[] { 'a', 'b' },
            new[] { 'c', 'd' }
        };
        string[] words = { "abcb" };
        var result = new Solution().FindWords(board, words);
        Assert.Empty(result);
    }
}
}
