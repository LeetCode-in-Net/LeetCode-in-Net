namespace LeetCodeNet.G0301_0400.S0399_evaluate_division {

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public static class ArrayUtils {
    public static IList<IList<string>> GetLists(string[][] array) {
        var result = new List<IList<string>>();
        foreach (var innerArray in array) {
            result.Add(innerArray.ToList());
        }
        return result;
    }
}

public class SolutionTest {
    private const double Tolerance = 0.00001;

    [Fact]
    public void CalcEquation() {
        IList<IList<string>> equations = ArrayUtils.GetLists(new string[][] {new string[] {"a", "b"}, new string[] {"b", "c"}});
        double[] values = new double[] {2.0, 3.0};
        IList<IList<string>> queries =
            ArrayUtils.GetLists(
                new string[][] {
                    new string[] {"a", "c"}, new string[] {"b", "a"}, new string[] {"a", "e"}, new string[] {"a", "a"}, new string[] {"x", "x"}
                });
        double[] expected = {6.00000, 0.50000, -1.00000, 1.00000, -1.00000};
        // For comparing double arrays with precision, use a loop or a custom assertion method
        Assert.Equal(expected, new Solution().CalcEquation(equations, values, queries), Tolerance);
    }

    [Fact]
    public void CalcEquation2() {
        IList<IList<string>> equations =
            ArrayUtils.GetLists(new string[][] {new string[] {"a", "b"}, new string[] {"b", "c"}, new string[] {"bc", "cd"}});
        double[] values = new double[] {1.5, 2.5, 5.0};
        IList<IList<string>> queries =
            ArrayUtils.GetLists(
                new string[][] {new string[] {"a", "c"}, new string[] {"c", "b"}, new string[] {"bc", "cd"}, new string[] {"cd", "bc"}});
        double[] expected = {3.75000, 0.40000, 5.00000, 0.20000};
        Assert.Equal(expected, new Solution().CalcEquation(equations, values, queries), Tolerance);
    }

    [Fact]
    public void CalcEquation3() {
        // Direct initialization of List<List<string>>
        IList<IList<string>> equations = new List<IList<string>> {
            new List<string> {"a", "b"}
        };
        double[] values = new double[] {0.5};
        IList<IList<string>> queries =
            ArrayUtils.GetLists(
                new string[][] {new string[] {"a", "b"}, new string[] {"b", "a"}, new string[] {"a", "c"}, new string[] {"x", "y"}});
        double[] expected = {0.50000, 2.00000, -1.00000, -1.00000};
        Assert.Equal(expected, new Solution().CalcEquation(equations, values, queries), Tolerance);
    }
}
}
