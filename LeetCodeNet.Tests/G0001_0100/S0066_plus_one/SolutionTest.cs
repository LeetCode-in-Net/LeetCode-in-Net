namespace LeetCodeNet.G0001_0100.S0066_plus_one {
    
using Xunit;

public class SolutionTest {
    [Fact]
    public void PlusOne() {
        var solution = new Solution();
        Assert.Equal(new int[] {1,2,4}, solution.PlusOne(new int[] {1,2,3}));
    }

    [Fact]
    public void PlusOne2() {
        var solution = new Solution();
        Assert.Equal(new int[] {4,3,2,2}, solution.PlusOne(new int[] {4,3,2,1}));
    }

    [Fact]
    public void PlusOne3() {
        var solution = new Solution();
        Assert.Equal(new int[] {1}, solution.PlusOne(new int[] {0}));
    }

    [Fact]
    public void PlusOne4() {
        var solution = new Solution();
        Assert.Equal(new int[] {1,0}, solution.PlusOne(new int[] {9}));
    }

    [Fact]
    public void PlusOne5() {
        var solution = new Solution();
        Assert.Equal(new int[] {1,0,0,0}, solution.PlusOne(new int[] {9,9,9}));
    }
}
}
