namespace LeetCodeNet.G0101_0200.S0150_evaluate_reverse_polish_notation {

// #Medium #Top_Interview_Questions #Array #Math #Stack #Programming_Skills_II_Day_3
// #Top_Interview_150_Stack #2025_07_12_Time_11_ms_(77.03%)_Space_44.57_MB_(49.39%)

using System.Collections.Generic;

public class Solution {
    public int EvalRPN(string[] tokens) {
        var st = new Stack<int>();
        foreach (string token in tokens) {
            if (!char.IsDigit(token[token.Length - 1])) {
                int second = st.Pop();
                int first = st.Pop();
                st.Push(Eval(first, second, token));
            } else {
                st.Push(int.Parse(token));
            }
        }
        return st.Pop();
    }

    private int Eval(int first, int second, string op) {
        return op switch {
            "+" => first + second,
            "-" => first - second,
            "*" => first * second,
            _ => first / second
        };
    }
}
}
