namespace LeetCodeNet.G0101_0200.S0152_maximum_product_subarray {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxProduct() {
        Assert.Equal(6, new Solution().MaxProduct(new int[] {2, 3, -2, 4}));
    }

    [Fact]
    public void MaxProduct2() {
        Assert.Equal(0, new Solution().MaxProduct(new int[] {-2, 0, -1}));
    }
}
}
