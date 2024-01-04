namespace LeetCodeNet.G0001_0100.S0049_group_anagrams
{

    using System;
    using Xunit;

    public class SolutionTest
    {
        [Fact]
        public void GroupAnagrams()
        {
            List<List<string>> exected = new List<List<string>> { new List<string> { "eat", "tea", "ate" }, new List<string> { "tan", "nat" }, new List<string> { "bat" } };
            Assert.Equal(exected, new Solution().GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }));
        }

        [Fact]
        public void GroupAnagrams2()
        {
            List<List<string>> exected = new List<List<string>> { new List<string> { "" } };
            Assert.Equal(exected, new Solution().GroupAnagrams(new string[] { "" }));
        }

        [Fact]
        public void GroupAnagrams3()
        {
            List<List<string>> exected = new List<List<string>> { new List<string> { "a" } };
            Assert.Equal(exected, new Solution().GroupAnagrams(new string[] { "a" }));
        }
    }
}
