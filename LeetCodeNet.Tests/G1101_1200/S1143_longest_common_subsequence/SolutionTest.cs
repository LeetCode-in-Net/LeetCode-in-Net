namespace LeetCodeNet.G1101_1200.S1143_longest_common_subsequence {

using Xunit;

public class SolutionTest {
    [Fact]
    public void LongestCommonSubsequence() {
        Assert.Equal(3, new Solution().LongestCommonSubsequence("abcde", "ace"));
    }

    [Fact]
    public void LongestCommonSubsequence2() {
        Assert.Equal(3, new Solution().LongestCommonSubsequence("abc", "abc"));
    }

    [Fact]
    public void LongestCommonSubsequence3() {
        Assert.Equal(0, new Solution().LongestCommonSubsequence("abc", "def"));
    }
}
}
