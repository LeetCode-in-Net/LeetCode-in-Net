namespace LeetCodeNet.G0001_0100.S0039_combination_sum {

using Xunit;
using System.Collections.Generic;
using System.Linq;

public class SolutionTest {
    [Fact]
    public void CombinationSum() {
        var expected = new List<List<int>> { new List<int> {7}, new List<int> {3, 2, 2} };
        var actual = new Solution().CombinationSum(new int[] {2, 3, 6, 7}, 7);
        Assert.True(CompareLists(expected, actual));
    }

    [Fact]
    public void CombinationSum2() {
        var expected = new List<List<int>> { new List<int> {5, 3}, new List<int> {3, 3, 2}, new List<int> {2, 2, 2, 2} };
        var actual = new Solution().CombinationSum(new int[] {2, 3, 5}, 8);
        Assert.True(CompareLists(expected, actual));
    }

    [Fact]
    public void CombinationSum3() {
        var expected = new List<List<int>> {};
        var actual = new Solution().CombinationSum(new int[] {2}, 1);
        Assert.True(CompareLists(expected, actual));
    }

    private bool CompareLists(List<List<int>> list1, List<List<int>> list2) {
        if (list1.Count != list2.Count) return false;
        for (int i = 0; i < list1.Count; i++) {
            if (!list1[i].SequenceEqual(list2[i])) return false;
        }
        return true;
    }
}
}
