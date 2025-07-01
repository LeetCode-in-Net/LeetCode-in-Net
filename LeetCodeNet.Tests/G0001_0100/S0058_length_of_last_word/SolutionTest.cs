using Xunit;

namespace LeetCodeNet.G0001_0100.S0058_length_of_last_word {
    public class SolutionTest {
        [Fact]
        public void LengthOfLastWord_Normal() {
            Assert.Equal(5, new Solution().LengthOfLastWord("Hello World"));
        }

        [Fact]
        public void LengthOfLastWord_Spaces() {
            Assert.Equal(4, new Solution().LengthOfLastWord("   fly me   to   the moon  "));
        }

        [Fact]
        public void LengthOfLastWord_MultipleWords() {
            Assert.Equal(6, new Solution().LengthOfLastWord("luffy is still joyboy"));
        }

        [Fact]
        public void LengthOfLastWord_SingleChar() {
            Assert.Equal(1, new Solution().LengthOfLastWord("a"));
        }

        [Fact]
        public void LengthOfLastWord_OnlySpaces() {
            Assert.Equal(0, new Solution().LengthOfLastWord(" "));
        }
    }
}
