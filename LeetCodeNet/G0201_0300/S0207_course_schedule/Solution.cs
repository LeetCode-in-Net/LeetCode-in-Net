namespace LeetCodeNet.G0201_0300.S0207_course_schedule {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Depth_First_Search
// #Breadth_First_Search #Graph #Topological_Sort #Top_Interview_150_Graph_General
// #Big_O_Time_O(N)_Space_O(N) #2024_01_10_Time_95_ms_(91.94%)_Space_47.1_MB_(36.27%)

using System.Collections.Generic;

public class Solution {
    private static readonly int WHITE = 0;
    private static readonly int GRAY = 1;
    private static readonly int BLACK = 2;

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] adj = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++) {
            adj[i] = new List<int>();
        }
        foreach (int[] pre in prerequisites) {
            adj[pre[1]].Add(pre[0]);
        }
        int[] colors = new int[numCourses];
        for (int i = 0; i < numCourses; i++) {
            if (colors[i] == WHITE && adj[i].Count > 0 && HasCycle(adj, i, colors)) {
                return false;
            }
        }
        return true;
    }

    private bool HasCycle(List<int>[] adj, int node, int[] colors) {
        colors[node] = GRAY;
        foreach (int nei in adj[node]) {
            if (colors[nei] == GRAY) {
                return true;
            }
            if (colors[nei] == WHITE && HasCycle(adj, nei, colors)) {
                return true;
            }
        }
        colors[node] = BLACK;
        return false;
    }
}
}
