namespace LeetCodeNet.G0001_0100.S0078_subsets {

    using System;
    using Xunit;

    public class SolutionTest {
        [Fact]
        public void Combine() {
            var output = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 }, new List<int> { 1, 4 }, new List<int> { 2, 3 }, new List<int> { 2, 4 }, new List<int> { 3, 4 } };
            Assert.Equal(output, new Solution().Combine(4, 2));
        }

        [Fact]
        public void Combine2() {
            var output = new List<List<int>> { new List<int> { 1 } };
            Assert.Equal(output, new Solution().Combine(1, 1));
        }
    }
}
