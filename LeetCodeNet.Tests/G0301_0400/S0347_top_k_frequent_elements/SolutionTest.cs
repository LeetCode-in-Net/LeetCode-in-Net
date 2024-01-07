namespace LeetCodeNet.G0301_0400.S0347_top_k_frequent_elements {

using Xunit;

public class SolutionTest {
    [Fact]
    public void TopKFrequent() {
        Assert.Equal(new int[] {1, 2},
            new Solution().TopKFrequent(new int[] {1, 1, 1, 2, 2, 3}, 2));
    }

    [Fact]
    public void TopKFrequent2() {
        Assert.Equal(new int[] {1}, new Solution().TopKFrequent(new int[] {1}, 1));
    }
}
}
