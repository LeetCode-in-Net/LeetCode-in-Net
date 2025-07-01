namespace LeetCodeNet.G0001_0100.S0058_length_of_last_word {

using Xunit;

public class SolutionTest {
    [Fact]
    public void LengthOfLastWord() {
        Assert.Equal(5, new Solution().LengthOfLastWord("Hello World"));
    }

    [Fact]
    public void LengthOfLastWord2() {
        Assert.Equal(4, new Solution().LengthOfLastWord("   fly me   to   the moon  "));
    }

    [Fact]
    public void LengthOfLastWord3() {
        Assert.Equal(6, new Solution().LengthOfLastWord("luffy is still joyboy"));
    }

    [Fact]
    public void LengthOfLastWord4() {
        Assert.Equal(1, new Solution().LengthOfLastWord("a"));
    }

    [Fact]
    public void LengthOfLastWord5() {
        Assert.Equal(0, new Solution().LengthOfLastWord(" "));
    }
}
}
