namespace LeetCodeNet.G0101_0200.S0173_binary_search_tree_iterator {

    using Xunit;
    using System.Collections.Generic;
    using LeetCodeNet.Com_github_leetcode;

    public class BSTIteratorTest {
        [Fact]
        public void IteratorBST() {
            var left = new TreeNode(3);
            var right = new TreeNode(15, new TreeNode(9), new TreeNode(20));
            var root = new TreeNode(7, left, right);
            var iterator = new BSTIterator(root);
            Assert.Equal(3, iterator.Next());
            Assert.Equal(7, iterator.Next());
            Assert.True(iterator.HasNext());
            Assert.Equal(9, iterator.Next());
            Assert.True(iterator.HasNext());
            Assert.Equal(15, iterator.Next());
            Assert.True(iterator.HasNext());
            Assert.Equal(20, iterator.Next());
            Assert.False(iterator.HasNext());
        }
    }
}
