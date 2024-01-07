namespace LeetCodeNet.G0201_0300.S0283_move_zeroes {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MoveZeroes() {
        int[] array = {0, 1, 0, 3, 12};
        new Solution().MoveZeroes(array);
        Assert.Equal(new int[] {1, 3, 12, 0, 0}, array);
    }

    [Fact]
    public void MoveZeroes2() {
        int[] array = {0};
        new Solution().MoveZeroes(array);
        Assert.Equal(new int[] {0}, array);
    }
}
}
