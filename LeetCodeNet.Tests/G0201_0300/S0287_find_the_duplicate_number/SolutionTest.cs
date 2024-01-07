namespace LeetCodeNet.G0201_0300.S0287_find_the_duplicate_number {

using Xunit;

public class SolutionTest {
    [Fact]
    public void FindDuplicate() {
        Assert.Equal(2, new Solution().FindDuplicate(new int[] {1, 3, 4, 2, 2}));
    }

    [Fact]
    public void FindDuplicate2() {
        Assert.Equal(3, new Solution().FindDuplicate(new int[] {3, 1, 3, 4, 2}));
    }

    [Fact]
    public void FindDuplicate3() {
        Assert.Equal(1, new Solution().FindDuplicate(new int[] {1, 1}));
    }

    [Fact]
    public void FindDuplicate4() {
        Assert.Equal(1, new Solution().FindDuplicate(new int[] {1, 1, 2}));
    }
}
}
