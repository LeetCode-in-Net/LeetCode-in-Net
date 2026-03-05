namespace LeetCodeNet.G0001_0100.S0006_zigzag_conversion {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Convert() {
        Assert.Equal("PAHNAPLSIIGYIR", Solution.Convert("PAYPALISHIRING", 3));
    }

    [Fact]
    public void Convert2() {
        Assert.Equal("PINALSIGYAHRPI", Solution.Convert("PAYPALISHIRING", 4));
    }
}
}
