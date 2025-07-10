namespace LeetCodeNet.G0101_0200.S0127_word_ladder {

    using Xunit;
    using System.Collections.Generic;

    public class SolutionTest {
        [Fact]
        public void LadderLength() {
            Assert.Equal(5, new Solution().LadderLength(
                "hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log", "cog"}));
        }

        [Fact]
        public void LadderLength2() {
            Assert.Equal(0, new Solution().LadderLength(
                "hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log"}));
        }
    }
}
