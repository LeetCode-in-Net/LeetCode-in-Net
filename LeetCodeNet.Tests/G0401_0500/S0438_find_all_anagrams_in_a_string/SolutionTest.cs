namespace LeetCodeNet.G0401_0500.S0438_find_all_anagrams_in_a_string {

using System.Collections.Generic;
using Xunit;

public class SolutionTest {
    [Fact]
    public void FindAnagrams() {
        Assert.Equal(new List<int> {0, 6}, new Solution().FindAnagrams("cbaebabacd", "abc"));
    }

    [Fact]
    public void FindAnagrams2() {
        Assert.Equal(new List<int> {0, 1, 2}, new Solution().FindAnagrams("abab", "ab"));
    }
}
}
