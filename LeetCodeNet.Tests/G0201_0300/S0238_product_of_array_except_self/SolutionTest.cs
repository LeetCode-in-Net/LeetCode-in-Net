namespace LeetCodeNet.G0201_0300.S0238_product_of_array_except_self {

using Xunit;

public class SolutionTest {
    [Fact]
    public void ProductExceptSelf() {
        Assert.Equal(
            new int[] { 24, 12, 8, 6 },
            new Solution().ProductExceptSelf(new int[] { 1, 2, 3, 4 })
        );
    }

    [Fact]
    public void ProductExceptSelf2() {
        Assert.Equal(
            new int[] { 0, 0, 9, 0, 0 },
            new Solution().ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 })
        );
    }
}
}
