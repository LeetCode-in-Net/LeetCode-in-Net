namespace LeetCodeNet.G0001_0100.S0006_zigzag_conversion {

using Xunit;
using System;

public class SolutionTest {
    [Fact]
    public void Convert() {
        Assert.Equal("PAHNAPLSIIGYIR", new Solution().Convert("PAYPALISHIRING", 3));
    }

    [Fact]
    public void Convert2() {
        Assert.Equal("PINALSIGYAHRPI", new Solution().Convert("PAYPALISHIRING", 4));
    }
}
}
