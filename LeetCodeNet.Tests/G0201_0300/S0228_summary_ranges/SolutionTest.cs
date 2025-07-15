namespace LeetCodeNet.G0201_0300.S0228_summary_ranges {

using System.Collections.Generic;
using Xunit;

public class SolutionTest {
    [Fact]
    public void SummaryRanges() {
        var expected = new List<string> { "0->2", "4->5", "7" };
        Assert.Equal(expected, new Solution().SummaryRanges(new[] { 0, 1, 2, 4, 5, 7 }));
    }

    [Fact]
    public void SummaryRanges2() {
        var expected = new List<string> { "0", "2->4", "6", "8->9" };
        Assert.Equal(expected, new Solution().SummaryRanges(new[] { 0, 2, 3, 4, 6, 8, 9 }));
    }
}
}
