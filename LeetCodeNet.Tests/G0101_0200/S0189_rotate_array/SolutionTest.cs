namespace LeetCodeNet.G0101_0200.S0189_rotate_array {

using Xunit;

public class SolutionTest {
    [Fact]
    public void Rotate() {
        int[] array = new int[] {1, 2, 3, 4, 5, 6, 7};
        new Solution().Rotate(array, 3);
        Assert.Equal(new int[] {5, 6, 7, 1, 2, 3, 4}, array);
    }

    [Fact]
    public void Rotate2() {
        int[] array = new int[] {-1, -100, 3, 99};
        new Solution().Rotate(array, 2);
        Assert.Equal(new int[] {3, 99, -1, -100}, array);
    }
}
}
