namespace LeetCodeNet.G0201_0300.S0207_course_schedule {

using Xunit;

public class SolutionTest {
    [Fact]
    public void CanFinish() {
        Assert.True(new Solution().CanFinish(2, new int[][] { { 1, 0 } }));
    }

    [Fact]
    public void CanFinish2() {
        Assert.False(new Solution().CanFinish(2, new int[][] { { 1, 0 }, { 0, 1 } }));
    }
}
}
