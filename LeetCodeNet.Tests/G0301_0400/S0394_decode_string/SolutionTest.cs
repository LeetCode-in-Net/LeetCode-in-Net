namespace LeetCodeNet.G0301_0400.S0394_decode_string {

using Xunit;

public class SolutionTest {
    [Fact]
    public void DecodeString() {
        Assert.Equal("aaabcbc", new Solution().DecodeString("3[a]2[bc]"));
    }

    [Fact]
    public void DecodeString2() {
        Assert.Equal("accaccacc", new Solution().DecodeString("3[a2[c]]"));
    }

    [Fact]
    public void DecodeString3() {
        Assert.Equal("abcabccdcdcdef", new Solution().DecodeString("2[abc]3[cd]ef"));
    }

    [Fact]
    public void DecodeString4() {
        Assert.Equal("abccdcdcdxyz", new Solution().DecodeString("abc3[cd]xyz"));
    }
}
}
