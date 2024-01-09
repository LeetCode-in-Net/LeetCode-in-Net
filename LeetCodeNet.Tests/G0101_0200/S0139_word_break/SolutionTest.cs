namespace LeetCodeNet.G0101_0200.S0139_word_break {

using Xunit;

public class SolutionTest {
    [Fact]
    public void WordBreak() {
        Assert.True(new Solution().WordBreak("leetcode", new List<string> { "leet", "code" }));
    }

    [Fact]
    public void WordBreak2() {
        Assert.True(new Solution().WordBreak("applepenapple", new List<string> { "apple", "pen" }));
    }

    [Fact]
    public void WordBreak3() {
        Assert.False(new Solution().WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" }));
    }
}
}
