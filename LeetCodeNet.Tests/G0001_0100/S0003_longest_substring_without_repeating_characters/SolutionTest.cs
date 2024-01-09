namespace LeetCodeNet.G0001_0100.S0003_longest_substring_without_repeating_characters {

using Xunit;

public class SolutionTest {
    [Fact]
    public void LengthOfLongestSubstring() {
        Assert.Equal(3, new Solution().LengthOfLongestSubstring("abcabcbb"));
    }

    [Fact]
    public void LengthOfLongestSubstring2() {
        Assert.Equal(1, new Solution().LengthOfLongestSubstring("bbbbb"));
    }

    [Fact]
    public void LengthOfLongestSubstring3() {
        Assert.Equal(3, new Solution().LengthOfLongestSubstring("pwwkew"));
    }
}
}
