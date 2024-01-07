namespace LeetCodeNet.G0201_0300.S0239_sliding_window_maximum {

using Xunit;

public class SolutionTest {
    [Fact]
    public void MaxSlidingWindow() {
        Assert.Equal(new int[] {3, 3, 5, 5, 6, 7},
            new Solution().MaxSlidingWindow(new int[] {1, 3, -1, -3, 5, 3, 6, 7}, 3));
    }

    [Fact]
    public void MaxSlidingWindow2() {
        Assert.Equal(new int[] {1}, new Solution().MaxSlidingWindow(new int[] {1}, 1));
    }
}
}
