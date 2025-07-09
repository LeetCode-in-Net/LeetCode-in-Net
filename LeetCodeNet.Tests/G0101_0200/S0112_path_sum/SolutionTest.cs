namespace LeetCodeNet.G0101_0200.S0112_path_sum {

    using Xunit;
    using System.Collections.Generic;
    using LeetCodeNet.Com_github_leetcode;

    public class SolutionTest {
        [Fact]
        public void HasPathSum() {
            var root = TreeNode.Create(new List<int?> {5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1});
            Assert.True(new Solution().HasPathSum(root, 22));
        }

        [Fact]
        public void HasPathSum2() {
            var root = TreeNode.Create(new List<int?> {1, 2, 3});
            Assert.False(new Solution().HasPathSum(root, 22));
        }

        [Fact]
        public void HasPathSum3() {
            Assert.False(new Solution().HasPathSum(null, 0));
        }
    }
} 