namespace LeetCodeNet.G0201_0300.S0201_bitwise_and_of_numbers_range {

using Xunit;

public class SolutionTest {
    [Fact]
    public void RangeBitwiseAnd() {
        Assert.Equal(4, new Solution().RangeBitwiseAnd(5, 7));
    }

    [Fact]
    public void RangeBitwiseAnd2() {
        Assert.Equal(0, new Solution().RangeBitwiseAnd(0, 0));
    }

    [Fact]
    public void RangeBitwiseAnd3() {
        Assert.Equal(0, new Solution().RangeBitwiseAnd(1, 2147483647));
    }
}
}
