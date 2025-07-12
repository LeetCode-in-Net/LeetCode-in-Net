namespace LeetCodeNet.G0101_0200.S0133_clone_graph {

// #Medium #Hash_Table #Depth_First_Search #Breadth_First_Search #Graph #Udemy_Graph
// #Top_Interview_150_Graph_General #2025_07_12_Time_117_ms_(96.34%)_Space_47.31_MB_(97.95%)

using System.Collections.Generic;

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        return CloneGraph(node, new Dictionary<Node, Node>());
    }

    private Node CloneGraph(Node node, Dictionary<Node, Node> processedNodes) {
        if (node == null) {
            return null;
        } else if (processedNodes.ContainsKey(node)) {
            return processedNodes[node];
        }
        Node newNode = new Node();
        processedNodes[node] = newNode;
        newNode.val = node.val;
        newNode.neighbors = new List<Node>();
        foreach (Node neighbor in node.neighbors) {
            Node clonedNeighbor = CloneGraph(neighbor, processedNodes);
            if (clonedNeighbor != null) {
                newNode.neighbors.Add(clonedNeighbor);
            }
        }
        return newNode;
    }
}
}
