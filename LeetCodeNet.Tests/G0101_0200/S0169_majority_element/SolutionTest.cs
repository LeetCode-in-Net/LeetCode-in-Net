namespace LeetCodeNet.G0101_0200.S0169_majority_element {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MajorityElement() {
        Assert.Equal(3, new Solution().MajorityElement(new int[] {3, 2, 3}));
    }

    [Fact]
    public void MajorityElement2() {
        Assert.Equal(2, new Solution().MajorityElement(new int[] {2, 2, 1, 1, 1, 2, 2}));
    }
}
}
