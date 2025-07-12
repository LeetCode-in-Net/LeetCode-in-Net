namespace LeetCodeNet.G0101_0200.S0151_reverse_words_in_a_string {

    using Xunit;

    public class SolutionTest {
        [Fact]
        public void ReverseWords() {
            Assert.Equal("blue is sky the", new Solution().ReverseWords("the sky is blue"));
        }

        [Fact]
        public void ReverseWords2() {
            Assert.Equal("world hello", new Solution().ReverseWords("  hello world  "));
        }

        [Fact]
        public void ReverseWords3() {
            Assert.Equal("example good a", new Solution().ReverseWords("a good   example"));
        }
    }
}
