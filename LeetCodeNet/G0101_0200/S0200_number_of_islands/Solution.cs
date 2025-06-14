namespace LeetCodeNet.G0101_0200.S0200_number_of_islands {

// #Medium #Top_100_Liked_Questions #Top_Interview_Questions #Array #Depth_First_Search
// #Breadth_First_Search #Matrix #Union_Find
// #Algorithm_II_Day_6_Breadth_First_Search_Depth_First_Search
// #Graph_Theory_I_Day_1_Matrix_Related_Problems #Level_1_Day_9_Graph/BFS/DFS #Udemy_Graph
// #Top_Interview_150_Graph_General #Big_O_Time_O(M*N)_Space_O(M*N)
// #2025_06_14_Time_131_ms_(65.99%)_Space_52.77_MB_(58.07%)

public class Solution {
    public int NumIslands(char[][] grid) {
        int islands = 0;
        if (grid != null && grid.Length != 0 && grid[0].Length != 0) {
            for (int i = 0; i < grid.Length; i++) {
                for (int j = 0; j < grid[0].Length; j++) {
                    if (grid[i][j] == '1') {
                        Dfs(grid, i, j);
                        islands++;
                    }
                }
            }
        }
        return islands;
    }

    private void Dfs(char[][] grid, int x, int y) {
        if (x < 0 || grid.Length <= x || y < 0 || grid[0].Length <= y || grid[x][y] != '1') {
            return;
        }
        grid[x][y] = 'x';
        Dfs(grid, x + 1, y);
        Dfs(grid, x - 1, y);
        Dfs(grid, x, y + 1);
        Dfs(grid, x, y - 1);
    }
}
}
