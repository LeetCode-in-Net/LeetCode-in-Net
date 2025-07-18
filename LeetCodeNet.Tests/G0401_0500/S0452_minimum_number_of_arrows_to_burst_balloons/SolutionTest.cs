namespace LeetCodeNet.G0401_0500.S0452_minimum_number_of_arrows_to_burst_balloons {

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xunit;

public static class CommonUtils {
    public static int[][] ConvertLeetCode2DArrayInputToArray(string input) {
        string[] rawPairs = input.TrimStart('[').TrimEnd(']').Split("],[", StringSplitOptions.RemoveEmptyEntries);
        List<int[]> result = new List<int[]>();
        foreach (string pair in rawPairs) {
            // Split each pair by comma
            string[] numbers = pair.Split(',');
            if (numbers.Length == 2) {
                int[] intArray = new int[2];
                if (int.TryParse(numbers[0], out intArray[0]) && int.TryParse(numbers[1], out intArray[1])) {
                    result.Add(intArray);
                } else {
                    throw new FormatException($"Invalid number format in pair: {pair}");
                }
            } else {
                throw new FormatException($"Invalid pair format: {pair}");
            }
        }
        return result.ToArray();
    }
}

public class SolutionTest {
    [Fact]
    public void FindMinArrowShots() {
        int[][] points =
            CommonUtils.ConvertLeetCode2DArrayInputToArray(
                "[10,16],[2,8],[1,6],[7,12]");
        Assert.Equal(2, new Solution().FindMinArrowShots(points));
    }

    [Fact]
    public void FindMinArrowShots2() {
        int[][] points =
            CommonUtils.ConvertLeetCode2DArrayInputToArray(
                "[1,2],[3,4],[5,6],[7,8]");
        Assert.Equal(4, new Solution().FindMinArrowShots(points));
    }

    [Fact]
    public void FindMinArrowShots3() {
        int[][] points =
            CommonUtils.ConvertLeetCode2DArrayInputToArray(
                "[1,2],[2,3],[3,4],[4,5]");
        Assert.Equal(2, new Solution().FindMinArrowShots(points));
    }
}
}
