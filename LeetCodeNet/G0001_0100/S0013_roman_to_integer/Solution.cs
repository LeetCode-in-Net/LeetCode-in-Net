namespace LeetCodeNet.G0001_0100.S0013_roman_to_integer {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #String #Hash_Table #Math
// #Top_Interview_150_Array/String #2025_06_20_Time_1_ms_(99.81%)_Space_49.42_MB_(80.66%)

public class Solution
{
    public int RomanToInt(string s)
    {
        int x = 0;
        char y;
        for (int i = 0; i < s.Length; i++)
        {
            y = s[i];
            switch (y)
            {
                case 'I':
                    x = GetX(s, x, i, 1, 'V', 'X');
                    break;
                case 'V':
                    x += 5;
                    break;
                case 'X':
                    x = GetX(s, x, i, 10, 'L', 'C');
                    break;
                case 'L':
                    x += 50;
                    break;
                case 'C':
                    x = GetX(s, x, i, 100, 'D', 'M');
                    break;
                case 'D':
                    x += 500;
                    break;
                case 'M':
                    x += 1000;
                    break;
                default:
                    break;
            }
        }
        return x;
    }

    private int GetX(string s, int x, int i, int i2, char v, char x2)
    {
        if (i + 1 == s.Length)
        {
            x += i2;
        }
        else if (s[i + 1] == v)
        {
            x -= i2;
        }
        else if (s[i + 1] == x2)
        {
            x -= i2;
        }
        else
        {
            x += i2;
        }
        return x;
    }
}
}
