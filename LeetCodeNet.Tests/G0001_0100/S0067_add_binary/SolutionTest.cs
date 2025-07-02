namespace LeetCodeNet.G0001_0100.S0067_add_binary {

using Xunit;

public class SolutionTest {
    [Fact]
    public void AddBinary_Example1() {
        var solution = new Solution();
        Assert.Equal("100", solution.AddBinary("11", "1"));
    }

    [Fact]
    public void AddBinary_Example2() {
        var solution = new Solution();
        Assert.Equal("10101", solution.AddBinary("1010", "1011"));
    }

    [Fact]
    public void AddBinary_Zero() {
        var solution = new Solution();
        Assert.Equal("0", solution.AddBinary("0", "0"));
    }

    [Fact]
    public void AddBinary_DifferentLengths() {
        var solution = new Solution();
        Assert.Equal("1000", solution.AddBinary("1", "111"));
    }
}
}
