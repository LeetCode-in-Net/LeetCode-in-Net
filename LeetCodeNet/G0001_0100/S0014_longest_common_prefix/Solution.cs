namespace LeetCodeNet.G0001_0100.S0014_longest_common_prefix {

// #Easy #Top_Interview_Questions #String #Level_2_Day_2_String #Udemy_Strings
// #Top_Interview_150_Array/String #Big_O_Time_O(n*m)_Space_O(m)
// #2025_06_20_Time_0_ms_(100.00%)_Space_42.70_MB_(97.50%)

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length < 1)
        {
            return "";
        }
        if (strs.Length == 1)
        {
            return strs[0];
        }
        string temp = strs[0];
        int i = 1;
        string cur;
        while (!string.IsNullOrEmpty(temp) && i < strs.Length)
        {
            if (temp.Length > strs[i].Length)
            {
                temp = temp.Substring(0, strs[i].Length);
            }
            cur = strs[i].Substring(0, temp.Length);
            if (!cur.Equals(temp))
            {
                temp = temp.Substring(0, temp.Length - 1);
            }
            else
            {
                i++;
            }
        }
        return temp;
    }
}
}
