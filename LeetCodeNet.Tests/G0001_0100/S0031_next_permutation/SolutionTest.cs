namespace LeetCodeNet.G0001_0100.S0031_next_permutation {

using Xunit;

public class SolutionTest {
    [Fact]
    public void NextPermutation() {
        int[] array = new int[] {1, 2, 3};
        new Solution().NextPermutation(array);
        Assert.Equal(new int[] {1, 3, 2}, array);
    }

    [Fact]
    public void NextPermutation2() {
        int[] array = new int[] {3, 2, 1};
        new Solution().NextPermutation(array);
        Assert.Equal(new int[] {1, 2, 3}, array);
    }

    [Fact]
    public void NextPermutation3() {
        int[] array = new int[] {1, 1, 5};
        new Solution().NextPermutation(array);
        Assert.Equal(new int[] {1, 5, 1}, array);
    }
}
}
