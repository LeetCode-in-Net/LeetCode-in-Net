namespace LeetCodeNet.G0201_0300.S0224_basic_calculator {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Calculate() {
        Assert.Equal(2, new Solution().Calculate("1 + 1"));
    }

    [Fact]
    public void Calculate2() {
        Assert.Equal(3, new Solution().Calculate(" 2-1 + 2 "));
    }

    [Fact]
    public void Calculate3() {
        Assert.Equal(23, new Solution().Calculate("(1+(4+5+2)-3)+(6+8)"));
    }
}
}
