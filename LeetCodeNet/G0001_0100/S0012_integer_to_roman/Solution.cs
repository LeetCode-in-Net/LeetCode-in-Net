namespace LeetCodeNet.G0001_0100.S0012_integer_to_roman {

// #Medium #String #Hash_Table #Math #Top_Interview_150_Array/String #Big_O_Time_O(1)_Space_O(1)
// #2025_06_20_Time_2_ms_(87.59%)_Space_45.13_MB_(98.99%)

public class Solution {
    public string IntToRoman(int num) {
        var sb = new System.Text.StringBuilder();
        int m = 1000;
        int c = 100;
        int x = 10;
        int i = 1;
        num = Numerals(sb, num, m, ' ', ' ', 'M');
        num = Numerals(sb, num, c, 'M', 'D', 'C');
        num = Numerals(sb, num, x, 'C', 'L', 'X');
        Numerals(sb, num, i, 'X', 'V', 'I');
        return sb.ToString();
    }

    private int Numerals(System.Text.StringBuilder sb, int num, int one, char cTen, char cFive, char cOne) {
        int div = num / one;
        switch (div) {
            case 9:
                sb.Append(cOne);
                sb.Append(cTen);
                break;
            case 8:
                sb.Append(cFive);
                sb.Append(cOne);
                sb.Append(cOne);
                sb.Append(cOne);
                break;
            case 7:
                sb.Append(cFive);
                sb.Append(cOne);
                sb.Append(cOne);
                break;
            case 6:
                sb.Append(cFive);
                sb.Append(cOne);
                break;
            case 5:
                sb.Append(cFive);
                break;
            case 4:
                sb.Append(cOne);
                sb.Append(cFive);
                break;
            case 3:
                sb.Append(cOne);
                sb.Append(cOne);
                sb.Append(cOne);
                break;
            case 2:
                sb.Append(cOne);
                sb.Append(cOne);
                break;
            case 1:
                sb.Append(cOne);
                break;
            default:
                break;
        }
        return num - (div * one);
    }
}
}
