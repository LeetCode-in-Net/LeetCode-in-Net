namespace LeetCodeNet.G0301_0400.S0399_evaluate_division {

// #Medium #Array #Depth_First_Search #Breadth_First_Search #Graph #Union_Find #Shortest_Path
// #LeetCode_75_Graphs/DFS #Top_Interview_150_Graph_General
// #2025_07_18_Time_3_ms_(66.56%)_Space_48.00_MB_(43.48%)

using System;
using System.Collections.Generic;

public class Solution {
    private Dictionary<string, string> root;
    private Dictionary<string, double> rate;

    public double[] CalcEquation(
            IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        root = new Dictionary<string, string>();
        rate = new Dictionary<string, double>();
        int n = equations.Count;
        foreach (var equation in equations) {
            string x = equation[0];
            string y = equation[1];
            root[x] = x; // In C#, Dictionary uses [] for put/get
            root[y] = y;
            rate[x] = 1.0;
            rate[y] = 1.0;
        }
        for (int i = 0; i < n; ++i) {
            string x = equations[i][0];
            string y = equations[i][1];
            union(x, y, values[i]);
        }
        double[] result = new double[queries.Count];
        for (int i = 0; i < queries.Count; ++i) {
            string x = queries[i][0];
            string y = queries[i][1];
            if (!root.ContainsKey(x) || !root.ContainsKey(y)) {
                result[i] = -1;
                continue;
            }
            string rootX = findRoot(x, x, 1.0);
            string rootY = findRoot(y, y, 1.0);
            // In C#, string comparison uses .Equals()
            result[i] = rootX.Equals(rootY) ? rate[x] / rate[y] : -1.0; 
        }
        return result;
    }

    private void union(string x, string y, double v) {
        string rootX = findRoot(x, x, 1.0);
        string rootY = findRoot(y, y, 1.0);
        root[rootX] = rootY;
        double r1 = rate[x];
        double r2 = rate[y];
        rate[rootX] = v * r2 / r1;
    }

    private string findRoot(string originalX, string x, double r) {
        if (root[x].Equals(x)) { // In C#, Dictionary uses [] for get
            root[originalX] = x;
            rate[originalX] = r * rate[x];
            return x;
        }
        return findRoot(originalX, root[x], r * rate[x]);
    }
}
}
