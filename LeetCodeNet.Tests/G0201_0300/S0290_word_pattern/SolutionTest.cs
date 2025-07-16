namespace LeetCodeNet.G0201_0300.S0290_word_pattern {

using Xunit;

public class SolutionTest {
    [Fact]
    public void WordPattern1() {
        Assert.True(new Solution().WordPattern("abba", "dog cat cat dog"));
    }
    [Fact]
    public void WordPattern2() {
        Assert.False(new Solution().WordPattern("abba", "dog cat cat fish"));
    }
    [Fact]
    public void WordPattern3() {
        Assert.False(new Solution().WordPattern("aaaa", "dog cat cat dog"));
    }
    [Fact]
    public void WordPattern4() {
        Assert.False(new Solution().WordPattern("abba", "dog dog dog dog"));
    }
}
}
