namespace LeetCodeNet.G0101_0200.S0134_gas_station {

using Xunit;

public class SolutionTest {
    [Fact]
    public void CanCompleteCircuit() {
        Assert.Equal(3, new Solution().CanCompleteCircuit(new int[] {1, 2, 3, 4, 5}, new int[] {3, 4, 5, 1, 2}));
    }

    [Fact]
    public void CanCompleteCircuit2() {
        Assert.Equal(-1, new Solution().CanCompleteCircuit(new int[] {2, 3, 4}, new int[] {3, 4, 3}));
    }
}
}
