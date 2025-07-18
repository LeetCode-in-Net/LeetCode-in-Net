namespace LeetCodeNet.G0401_0500.S0433_minimum_genetic_mutation {

// #Medium #String #Hash_Table #Breadth_First_Search #Graph_Theory_I_Day_12_Breadth_First_Search
// #Top_Interview_150_Graph_BFS #2025_07_18_Time_1_ms_(78.46%)_Space_41.13_MB_(73.33%)

using System;
using System.Collections.Generic;

public class Solution {
    private IList<string> IsInBank(ISet<string> set, string cur) {
        List<string> res = new List<string>();
        foreach (string each in set) {
            int diff = 0;
            for (int i = 0; i < each.Length; i++) {
                if (each[i] != cur[i]) {
                    diff++;
                    if (diff > 1) {
                        break;
                    }
                }
            }
            if (diff == 1) {
                res.Add(each);
            }
        }
        return res;
    }

    public int MinMutation(string start, string end, string[] bank) {
        ISet<string> set = new HashSet<string>();
        foreach (string s in bank) {
            set.Add(s);
        }
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(start);
        int step = 0;
        while (queue.Count > 0) {
            int curSize = queue.Count;
            while (curSize-- > 0) {
                string cur = queue.Dequeue();
                if (cur.Equals(end)) {
                    return step;
                }
                foreach (string next in IsInBank(set, cur)) {
                    queue.Enqueue(next);
                    set.Remove(next);
                }
            }
            step++;
        }
        return -1;
    }
}
}
