namespace LeetCodeNet.G0001_0100.S0046_permutations {

using Xunit;
using System.Collections.Generic;
using System.Linq;

public class SolutionTest {
    [Fact]
    public void Permute() {
        var expected = new List<List<int>> { new List<int> {1, 2, 3}, new List<int> {1, 3, 2},
            new List<int> {2, 1, 3}, new List<int> {2, 3, 1}, new List<int> {3, 1, 2}, new List<int> {3, 2, 1} };
        var actual = new Solution().Permute(new int[] {1, 2, 3});
        Assert.True(CompareLists(expected, actual));
    }

    [Fact]
    public void Permute2() {
        var expected = new List<List<int>> { new List<int> {0, 1}, new List<int> {1, 0} };
        var actual = new Solution().Permute(new int[] {0, 1});
        Assert.True(CompareLists(expected, actual));
    }

    [Fact]
    public void Permute3() {
        var expected = new List<List<int>> { new List<int> {1} };
        var actual = new Solution().Permute(new int[] {1});
        Assert.True(CompareLists(expected, actual));
    }

    private bool CompareLists(IList<IList<int>> list1, IList<IList<int>> list2) {
        if (list1.Count != list2.Count) return false;
        for (int i = 0; i < list1.Count; i++) {
            if (!list1[i].SequenceEqual(list2[i])) return false;
        }
        return true;
    }
}
}
