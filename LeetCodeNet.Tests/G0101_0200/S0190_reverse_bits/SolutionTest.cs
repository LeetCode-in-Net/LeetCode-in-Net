namespace LeetCodeNet.G0101_0200.S0190_reverse_bits {

using Xunit;

public class SolutionTest {
    [Fact]
    public void reverseBits() {
        Assert.Equal(0b00111001011110000010100101000000u, new Solution().reverseBits(0b00000010100101000001111010011100u));
    }

    [Fact]
    public void reverseBits2() {
        Assert.Equal(0b10111111111111111111111111111111u, new Solution().reverseBits(0b11111111111111111111111111111101u));
    }
}
}
