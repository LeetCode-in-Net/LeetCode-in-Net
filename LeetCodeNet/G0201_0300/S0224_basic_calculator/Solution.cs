namespace LeetCodeNet.G0201_0300.S0224_basic_calculator {

// #Hard #String #Math #Stack #Recursion #Top_Interview_150_Stack
// #2025_07_15_Time_3_ms_(96.26%)_Space_42.26_MB_(95.95%)

public class Solution {
    public int Calculate(string s) {
        Stack<int> st = new Stack<int>();
        int ans = 0;
        int sum = 0;
        int sign = 1;
        st.Push(1);
        foreach (char ch in s) {
            if (ch >= '0' && ch <= '9') {
                sum = sum * 10 + ch - '0';
            } else if (ch == '(') {
                st.Push(sign);
            } else if (ch == ')') {
                st.Pop();
            } else if (ch == '-' || ch == '+') {
                ans += sum * sign;
                if (ch == '-') {
                    sign = -1 * st.Peek();
                } else {
                    sign = st.Peek();
                }
                sum = 0;
            }
        }
        ans += sum * sign;
        return ans;
    }
}
}
