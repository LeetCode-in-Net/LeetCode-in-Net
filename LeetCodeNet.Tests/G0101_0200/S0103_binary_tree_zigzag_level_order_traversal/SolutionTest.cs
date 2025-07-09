namespace LeetCodeNet.G0101_0200.S0103_binary_tree_zigzag_level_order_traversal {

    using LeetCodeNet.Com_github_leetcode;
    using Xunit;
    using System.Collections.Generic;

    public class SolutionTest {
        [Fact]
        public void ZigzagLevelOrder() {
            var root = TreeNode.Create(new List<int?> {3, 9, 20, null, null, 15, 7});
            var expected = new List<IList<int>> {
                new List<int> {3},
                new List<int> {20, 9},
                new List<int> {15, 7}
            };
            Assert.Equal(expected, new Solution().ZigzagLevelOrder(root));
        }

        [Fact]
        public void ZigzagLevelOrder2() {
            var root = TreeNode.Create(new List<int?> {1});
            var expected = new List<IList<int>> {
                new List<int> {1}
            };
            Assert.Equal(expected, new Solution().ZigzagLevelOrder(root));
        }

        [Fact]
        public void ZigzagLevelOrder3() {
            var expected = new List<IList<int>>();
            Assert.Equal(expected, new Solution().ZigzagLevelOrder(null));
        }
    }
} 