namespace LeetCodeNet.G0001_0100.S0028_find_the_index_of_the_first_occurrence_in_a_string {

using Xunit;

public class SolutionTest {
    [Fact]
    public void StrStr() {
        Assert.Equal(0, new Solution().StrStr("sadbutsad", "sad"));
    }

    [Fact]
    public void StrStr2() {
        Assert.Equal(-1, new Solution().StrStr("leetcode", "leeto"));
    }

    [Fact]
    public void StrStr3() {
        Assert.Equal(0, new Solution().StrStr("", ""));
    }
}
}
