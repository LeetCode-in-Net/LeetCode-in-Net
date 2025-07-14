namespace LeetCodeNet.G0201_0300.S0202_happy_number {

// #Easy #Top_Interview_Questions #Hash_Table #Math #Two_Pointers #Algorithm_II_Day_21_Others
// #Programming_Skills_I_Day_4_Loop #Level_2_Day_1_Implementation/Simulation
// #Top_Interview_150_Hashmap #2025_07_13_Time_0_ms_(100.00%)_Space_30.91_MB_(85.61%)

public class Solution {
    public bool IsHappy(int n) {
        bool happy;
        int a = n;
        int rem;
        int sum = 0;
        if (a == 1 || a == 7) {
            happy = true;
        } else if (a > 1 && a < 10) {
            happy = false;
        } else {
            while (a != 0) {
                rem = a % 10;
                sum = sum + (rem * rem);
                a = a / 10;
            }
            if (sum != 1) {
                happy = IsHappy(sum);
            } else {
                happy = true;
            }
        }
        return happy;
    }
}
}
