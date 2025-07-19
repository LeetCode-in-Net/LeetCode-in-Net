namespace LeetCodeNet.G0601_0700.S0637_average_of_levels_in_binary_tree {

using System;
using LeetCodeNet.Com_github_leetcode;
using Xunit;

public class SolutionTest {
    [Fact]
    public void AverageOfLevels() {
        TreeNode treeNode = TreeNode.Create(new List<int?> {3, 9, 20, null, null, 15, 7});
        Assert.Equal(new List<double> {3.00000, 14.50000, 11.00000}, new Solution().AverageOfLevels(treeNode),
                     new DoubleListComparer(0.00001));
    }

    [Fact]
    public void AverageOfLevels2() {
        TreeNode treeNode = TreeNode.Create(new List<int?> {3, 9, 20, 15, 7});
        Assert.Equal(new List<double> {3.00000, 14.50000, 11.00000}, new Solution().AverageOfLevels(treeNode),
                     new DoubleListComparer(0.00001));
    }
}

public class DoubleListComparer : IEqualityComparer<IList<double>> {
    private readonly double _tolerance;

    public DoubleListComparer(double tolerance) {
        _tolerance = tolerance;
    }

    public bool Equals(IList<double> x, IList<double> y) {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
        if (x.Count != y.Count) return false;

        for (int i = 0; i < x.Count; i++) {
            if (Math.Abs(x[i] - y[i]) > _tolerance) {
                return false;
            }
        }
        return true;
    }

    public int GetHashCode(IList<double> obj) {
        int hash = 17;
        foreach (var d in obj) {
            hash = hash * 31 + d.GetHashCode();
        }
        return hash;
    }
}
}
