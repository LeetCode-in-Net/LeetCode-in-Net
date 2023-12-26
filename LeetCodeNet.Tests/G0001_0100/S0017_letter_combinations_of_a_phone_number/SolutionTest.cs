namespace LeetCodeNet.G0001_0100.S0017_letter_combinations_of_a_phone_number {

using Xunit;
using System.Collections.Generic;

public class SolutionTest {
    [Fact]
    public void LetterCombinations() {
        Assert.Equal(
            new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" },
            new Solution().LetterCombinations("23")
        );
    }

    [Fact]
    public void LetterCombinations2() {
        Assert.Empty(new Solution().LetterCombinations(""));
    }

    [Fact]
    public void LetterCombinations3() {
        Assert.Equal(new List<string> { "a", "b", "c" }, new Solution().LetterCombinations("2"));
    }

    [Fact]
    public void LetterCombinations4() {
        Assert.Equal(new List<string> { "g", "h", "i" }, new Solution().LetterCombinations("4"));
    }

    [Fact]
    public void LetterCombinations5() {
        Assert.Equal(new List<string> { "j", "k", "l" }, new Solution().LetterCombinations("5"));
    }

    [Fact]
    public void LetterCombinations6() {
        Assert.Equal(new List<string> { "m", "n", "o" }, new Solution().LetterCombinations("6"));
    }

    [Fact]
    public void LetterCombinations7() {
        Assert.Equal(new List<string> { "p", "q", "r", "s" }, new Solution().LetterCombinations("7"));
    }

    @Fact
    public void LetterCombinations8() {
        Assert.Equal(new List<string> { "t", "u", "v" }, new Solution().LetterCombinations("8"));
    }

    [Fact]
    public void LetterCombinations9() {
        Assert.Equal(new List<string> { "w", "x", "y", "z" }, new Solution().LetterCombinations("9"));
    }
}
}
