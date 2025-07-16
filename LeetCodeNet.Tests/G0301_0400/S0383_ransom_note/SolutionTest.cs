namespace LeetCodeNet.G0301_0400.S0383_ransom_note {

using System;
using Xunit;

public class SolutionTest {
    [Fact]
    public void CanConstruct1() {
        Assert.False(new Solution().CanConstruct("a", "b"));
    }
    [Fact]
    public void CanConstruct2() {
        Assert.False(new Solution().CanConstruct("aa", "ab"));
    }
    [Fact]
    public void CanConstruct3() {
        Assert.True(new Solution().CanConstruct("aa", "aab"));
    }
}
}
