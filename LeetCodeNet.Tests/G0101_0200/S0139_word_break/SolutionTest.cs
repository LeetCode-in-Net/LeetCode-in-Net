namespace LeetCodeNet.G0101_0200.S0139_word_break {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void WordBreakTest1() {
        Assert.True(new Solution().WordBreak("leetcode", new List<string> { "leet", "code" }));
    }

    [Fact]
    public void WordBreakTest2() {
        Assert.True(new Solution().WordBreak("applepenapple", new List<string> { "apple", "pen" }));
    }

    [Fact]
    public void WordBreakTest3() {
        Assert.False(new Solution().WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" }));
    }
}
}
