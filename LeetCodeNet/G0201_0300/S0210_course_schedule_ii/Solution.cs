namespace LeetCodeNet.G0201_0300.S0210_course_schedule_ii {

// #Medium #Top_Interview_Questions #Depth_First_Search #Breadth_First_Search #Graph
// #Topological_Sort #Level_2_Day_11_Graph/BFS/DFS #Top_Interview_150_Graph_General
// #2025_07_14_Time_4_ms_(91.35%)_Space_53.47_MB_(15.48%)

using System.Collections.Generic;

public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var graph = new Dictionary<int, List<int>>();
        for (int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }
        foreach (var classes in prerequisites) {
            graph[classes[0]].Add(classes[1]);
        }
        var output = new List<int>();
        var visited = new Dictionary<int, bool>();
        foreach (var c in graph.Keys) {
            if (Dfs(c, graph, visited, output)) {
                return new int[0];
            }
        }
        return output.ToArray();
    }

    private bool Dfs(int course, Dictionary<int, List<int>> graph, Dictionary<int, bool> visited, List<int> output) {
        if (visited.ContainsKey(course)) {
            return visited[course];
        }
        visited[course] = true;
        foreach (var c in graph[course]) {
            if (Dfs(c, graph, visited, output)) {
                return true;
            }
        }
        visited[course] = false;
        output.Add(course);
        return false;
    }
}
}
