namespace LeetCodeNet.G0101_0200.S0129_sum_root_to_leaf_numbers {

    using Xunit;
    using System.Collections.Generic;
    using LeetCodeNet.Com_github_leetcode;

    public class SolutionTest {
        [Fact]
        public void SumNumbers() {
            var treeNode = TreeNode.Create(new List<int?> {1, 2, 3});
            Assert.Equal(25, new Solution().SumNumbers(treeNode));
        }

        [Fact]
        public void SumNumbers2() {
            var treeNode = TreeNode.Create(new List<int?> {4, 9, 0, 5, 1});
            Assert.Equal(1026, new Solution().SumNumbers(treeNode));
        }
    }
}
