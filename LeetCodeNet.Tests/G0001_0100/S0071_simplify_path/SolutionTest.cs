namespace LeetCodeNet.G0001_0100.S0071_simplify_path {
    using Xunit;
    public class SolutionTest {
        [Fact]
        public void SimplifyPath_Example1() {
            var solution = new Solution();
            Assert.Equal("/home", solution.SimplifyPath("/home/"));
        }

        [Fact]
        public void SimplifyPath_Example2() {
            var solution = new Solution();
            Assert.Equal("/", solution.SimplifyPath("/../"));
        }

        [Fact]
        public void SimplifyPath_Example3() {
            var solution = new Solution();
            Assert.Equal("/home/foo", solution.SimplifyPath("/home//foo/"));
        }

        [Fact]
        public void SimplifyPath_Example4() {
            var solution = new Solution();
            Assert.Equal("/c", solution.SimplifyPath("/a/./b/../../c/"));
        }

        [Fact]
        public void SimplifyPath_Complex() {
            var solution = new Solution();
            Assert.Equal("/a/b/c", solution.SimplifyPath("/a//b////c/d//././/.."));
        }
    }
}
