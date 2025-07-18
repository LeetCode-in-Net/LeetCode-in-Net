namespace LeetCodeNet.G0401_0500.S0427_construct_quad_tree {

// #Medium #Array #Tree #Matrix #Divide_and_Conquer #Top_Interview_150_Divide_and_Conquer
// #2025_07_18_Time_91_ms_(66.88%)_Space_47.25_MB_(80.00%)

using System.Text;

public class Node {
    public bool val;
    public bool isLeaf;
    public Node? topLeft;
    public Node? topRight;
    public Node? bottomLeft;
    public Node? bottomRight;

    public Node(bool val, bool isLeaf) {
        this.val = val;
        this.isLeaf = isLeaf;
        this.topLeft = null;
        this.topRight = null;
        this.bottomLeft = null;
        this.bottomRight = null;
    }

    public Node(
        bool val,
        bool isLeaf,
        Node? topLeft,
        Node? topRight,
        Node? bottomLeft,
        Node? bottomRight) {
        this.val = val;
        this.isLeaf = isLeaf;
        this.topLeft = topLeft;
        this.topRight = topRight;
        this.bottomLeft = bottomLeft;
        this.bottomRight = bottomRight;
    }

    public override string ToString() {
        StringBuilder sb = new StringBuilder();
        sb.Append(GetNodeString(this));
        sb.Append(GetNodeString(topLeft));
        sb.Append(GetNodeString(topRight));
        sb.Append(GetNodeString(bottomLeft));
        sb.Append(GetNodeString(bottomRight));
        return sb.ToString();
    }

    private string GetNodeString(Node? node) {
        if (node == null) {
            return "[]";
        }
        return $"[{(node.isLeaf ? "1" : "0")},{(node.val ? "1" : "0")}]";
    }
}

/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/
public class Solution {
    public Node Construct(int[][] grid) {
        return OptimizedDfs(grid, 0, 0, grid.Length);
    }

    private Node OptimizedDfs(int[][] grid, int rowStart, int colStart, int len) {
        int zeroCount = 0;
        int oneCount = 0;
        for (int row = rowStart; row < rowStart + len; row++) {
            bool isBreak = false;
            for (int col = colStart; col < colStart + len; col++) {
                if (grid[row][col] == 0) {
                    zeroCount++;
                } else {
                    oneCount++;
                }
                if (oneCount > 0 && zeroCount > 0) {
                    // We really no need to scan all.
                    // Once we know there are both 0 and 1 then we can break.
                    isBreak = true;
                    break;
                }
            }
            if (isBreak) {
                break;
            }
        }
        if (oneCount > 0 && zeroCount > 0) {
            int midLen = len / 2;
            Node topLeft = OptimizedDfs(grid, rowStart, colStart, midLen);
            Node topRight = OptimizedDfs(grid, rowStart, colStart + midLen, midLen);
            Node bottomLeft = OptimizedDfs(grid, rowStart + midLen, colStart, midLen);
            Node bottomRight = OptimizedDfs(grid, rowStart + midLen, colStart + midLen, midLen);
            bool isLeaf = false;
            return new Node(true, isLeaf, topLeft, topRight, bottomLeft, bottomRight);
        } else {
            bool resultVal = oneCount > 0;
            bool isLeaf = true;
            return new Node(resultVal, isLeaf);
        }
    }
}
}
