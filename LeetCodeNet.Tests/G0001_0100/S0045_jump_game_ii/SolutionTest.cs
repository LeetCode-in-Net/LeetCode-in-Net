namespace LeetCodeNet.G0001_0100.S0045_jump_game_ii {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Jump() {
        Assert.Equal(2, new Solution().Jump(new int[] {2, 3, 1, 1, 4}));
    }

    [Fact]
    public void Jump2() {
        Assert.Equal(2, new Solution().Jump(new int[] {2, 3, 0, 1, 4}));
    }
}
}
