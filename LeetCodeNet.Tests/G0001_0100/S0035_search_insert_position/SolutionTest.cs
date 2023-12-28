namespace LeetCodeNet.G0001_0100.S0035_search_insert_position {

using Xunit;

public class SolutionTest {
    [Fact]
    public void SearchInsert() {
        Assert.Equal(2, new Solution().SearchInsert(new int[] {1, 3, 5, 6}, 5));
    }

    [Fact]
    public void SearchInsert2() {
        Assert.Equal(1, new Solution().SearchInsert(new int[] {1, 3, 5, 6}, 2));
    }

    [Fact]
    public void SearchInsert3() {
        Assert.Equal(4, new Solution().SearchInsert(new int[] {1, 3, 5, 6}, 7));
    }
}
}
