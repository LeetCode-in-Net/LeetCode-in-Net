namespace LeetCodeNet.G0101_0200.S0125_valid_palindrome {

    using Xunit;

    public class SolutionTest {
        [Fact]
        public void IsPalindrome() {
            Assert.True(new Solution().IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [Fact]
        public void IsPalindrome2() {
            Assert.False(new Solution().IsPalindrome("race a car"));
        }

        [Fact]
        public void IsPalindrome3() {
            Assert.True(new Solution().IsPalindrome(" "));
        }
    }
}
