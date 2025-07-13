namespace LeetCodeNet.G0101_0200.S0191_number_of_1_bits {

using Xunit;

public class SolutionTest {
    [Fact]
    public void HammingWeight() {
        Assert.Equal(3, new Solution().HammingWeight(0b00000000000000000000000000001011u));
    }

    [Fact]
    public void HammingWeight2() {
        Assert.Equal(1, new Solution().HammingWeight(0b00000000000000000000000010000000u));
    }
}
}
