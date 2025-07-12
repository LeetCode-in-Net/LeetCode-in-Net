namespace LeetCodeNet.G0101_0200.S0150_evaluate_reverse_polish_notation {

    using Xunit;

    public class SolutionTest {
        [Fact]
        public void EvalRPN() {
            Assert.Equal(9, new Solution().EvalRPN(new string[] {"2", "1", "+", "3", "*"}));
        }

        [Fact]
        public void EvalRPN2() {
            Assert.Equal(6, new Solution().EvalRPN(new string[] {"4", "13", "5", "/", "+"}));
        }

        [Fact]
        public void EvalRPN3() {
            Assert.Equal(22, new Solution().EvalRPN(new string[] {
                "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"
            }));
        }
    }
}
