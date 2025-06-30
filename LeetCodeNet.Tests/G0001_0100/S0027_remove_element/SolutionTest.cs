using System.Linq;

namespace LeetCodeNet.G0001_0100.S0027_remove_element {

using Xunit;

public class SolutionTest {
    [Fact]
    public void RemoveElement() {
        var solution = new Solution();
        var nums = new int[] { 3, 2, 2, 3 };
        var val = 3;
        var expectedNums = new int[] { 2, 2 };
        var k = solution.RemoveElement(nums, val);
        Assert.Equal(expectedNums.Length, k);
        var actualNums = nums.Take(k).ToArray();
        System.Array.Sort(actualNums);
        Assert.Equal(expectedNums, actualNums);
    }

    [Fact]
    public void RemoveElement2() {
        var solution = new Solution();
        var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var val = 2;
        var expectedNums = new int[] { 0, 0, 1, 3, 4 };
        var k = solution.RemoveElement(nums, val);
        Assert.Equal(expectedNums.Length, k);
        var actualNums = nums.Take(k).ToArray();
        System.Array.Sort(actualNums);
        Assert.Equal(expectedNums, actualNums);
    }
}
}
