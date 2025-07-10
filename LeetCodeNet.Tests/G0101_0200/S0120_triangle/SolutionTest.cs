namespace LeetCodeNet.G0101_0200.S0120_triangle {

    using Xunit;
    using System.Collections.Generic;

    public class SolutionTest {
        [Fact]
        public void MinimumTotal() {
            var triangle = new List<IList<int>> {
                new List<int> {2},
                new List<int> {3, 4},
                new List<int> {6, 5, 7},
                new List<int> {4, 1, 8, 3}
            };
            Assert.Equal(11, new Solution().MinimumTotal(triangle));
        }

        [Fact]
        public void MinimumTotal2() {
            var triangle = new List<IList<int>> {
                new List<int> {-10}
            };
            Assert.Equal(-10, new Solution().MinimumTotal(triangle));
        }
    }
}
