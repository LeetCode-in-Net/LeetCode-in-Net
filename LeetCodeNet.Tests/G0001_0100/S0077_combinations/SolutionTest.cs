namespace LeetCodeNet.G0001_0100.S0077_combinations {

using Xunit;
using System.Collections.Generic;
using System.Linq;

public class SolutionTest {
    private List<List<int>> SortCombinations(IList<IList<int>> combos) {
        return combos.Select(x => x.OrderBy(i => i).ToList()).OrderBy(x => string.Join(",", x)).ToList();
    }

    [Fact]
    public void Combine() {
        var solution = new Solution();
        IList<IList<int>> expected = new List<IList<int>> {
            new List<int> {2,4}, new List<int> {3,4}, new List<int> {2,3}, new List<int> {1,2}, new List<int> {1,3}, new List<int> {1,4}
        };
        var result = solution.Combine(4, 2);
        Assert.Equal(SortCombinations(expected), SortCombinations(result));
    }

    [Fact]
    public void Combine2() {
        var solution = new Solution();
        var expected = new List<IList<int>> {
            new List<int> {1}
        };
            var result = solution.Combine(1, 1);
        Assert.Equal(SortCombinations(expected), SortCombinations(result));
    }
}
}
