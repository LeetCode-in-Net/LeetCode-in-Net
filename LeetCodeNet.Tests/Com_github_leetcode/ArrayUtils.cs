namespace LeetCodeNet.Com_github_leetcode {
using System.Collections.Generic;

public static class ArrayUtils {
    public static List<List<int>> GetLists(int[][] expected) {
        List<List<int>> expectedList = new List<List<int>>();
        foreach (int[] value in expected) {
            List<int> expectedItem = new List<int>();
            expectedList.Add(expectedItem);
            foreach (int item in value) {
                expectedItem.Add(item);
            }
        }
        return expectedList;
    }
}
}
