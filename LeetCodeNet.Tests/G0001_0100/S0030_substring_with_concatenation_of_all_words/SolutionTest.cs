using System.Collections.Generic;
using Xunit;

namespace LeetCodeNet.G0001_0100.S0030_substring_with_concatenation_of_all_words {
    public class SolutionTest {
        [Fact]
        public void FindSubstring() {
            var solution = new Solution();
            var result = solution.FindSubstring("barfoothefoobarman", new string[] { "foo", "bar" });
            var expected = new List<int> { 0, 9 };
            var resultList = new List<int>(result);
            resultList.Sort();
            expected.Sort();
            Assert.Equal(expected, resultList);
        }

        [Fact]
        public void FindSubstring2() {
            var solution = new Solution();
            var result = solution.FindSubstring("wordgoodgoodgoodbestword", new string[] { "word", "good", "best", "word" });
            Assert.Equal(new List<int>(), result);
        }

        [Fact]
        public void FindSubstring3() {
            var solution = new Solution();
            var result = solution.FindSubstring("barfoofoobarthefoobarman", new string[] { "bar", "foo", "the" });
            var expected = new List<int> { 6, 9, 12 };
            var resultList = new List<int>(result);
            resultList.Sort();
            expected.Sort();
            Assert.Equal(expected, resultList);
        }
    }
}
