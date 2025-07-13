namespace LeetCodeNet.G0201_0300.S0205_isomorphic_strings {

using Xunit;

public class SolutionTest {
    [Fact]
    public void IsIsomorphic() {
        Assert.True(new Solution().IsIsomorphic("egg", "add"));
    }

    [Fact]
    public void IsIsomorphic2() {
        Assert.False(new Solution().IsIsomorphic("foo", "bar"));
    }

    [Fact]
    public void IsIsomorphic3() {
        Assert.True(new Solution().IsIsomorphic("paper", "title"));
    }
}
}
