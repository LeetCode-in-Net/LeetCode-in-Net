namespace LeetCodeNet.G0001_0100.S0068_text_justification {

using Xunit;
using System.Collections.Generic;

public class SolutionTest {
    [Fact]
    public void FullJustify() {
        var solution = new Solution();
        var words = new string[] {"This", "is", "an", "example", "of", "text", "justification."};
        int maxWidth = 16;
        var expected = new List<string> {
            "This    is    an",
            "example  of text",
            "justification.  "
        };
        Assert.Equal(expected, solution.FullJustify(words, maxWidth));
    }

    [Fact]
    public void FullJustify2() {
        var solution = new Solution();
        var words = new string[] {"What","must","be","acknowledgment","shall","be"};
        int maxWidth = 16;
        var expected = new List<string> {
            "What   must   be",
            "acknowledgment  ",
            "shall be        "
        };
        Assert.Equal(expected, solution.FullJustify(words, maxWidth));
    }

    [Fact]
    public void FullJustify3() {
        var solution = new Solution();
        var words = new string[] {"Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"};
        int maxWidth = 20;
        var expected = new List<string> {
            "Science  is  what we",
            "understand      well",
            "enough to explain to",
            "a  computer.  Art is",
            "everything  else  we",
            "do                  "
        };
        Assert.Equal(expected, solution.FullJustify(words, maxWidth));
    }
}
}
