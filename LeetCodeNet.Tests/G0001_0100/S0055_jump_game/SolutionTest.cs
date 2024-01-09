namespace LeetCodeNet.G0001_0100.S0055_jump_game {

using Xunit;

public class SolutionTest {
    [Fact]
    public void CanJump() {
        Assert.True(new Solution().CanJump(new int[] { 2, 3, 1, 1, 4 }));
    }

    [Fact]
    public void CanJump2() {
        Assert.False(new Solution().CanJump(new int[] { 3, 2, 1, 0, 4 }));
    }
}
}
