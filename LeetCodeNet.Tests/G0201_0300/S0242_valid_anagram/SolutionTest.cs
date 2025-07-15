namespace LeetCodeNet.G0201_0300.S0242_valid_anagram {

using Xunit;

public class SolutionTest {
    [Fact]
    public void IsAnagram() {
        Assert.True(new Solution().IsAnagram("anagram", "nagaram"));
    }

    [Fact]
    public void IsAnagram2() {
        Assert.False(new Solution().IsAnagram("rat", "car"));
    }
}
}
