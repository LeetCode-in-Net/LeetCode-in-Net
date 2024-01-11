namespace LeetCodeNet.G0101_0200.S0155_min_stack {

// #Easy #Top_100_Liked_Questions #Top_Interview_Questions #Stack #Design
// #Data_Structure_II_Day_14_Stack_Queue #Programming_Skills_II_Day_18 #Level_2_Day_16_Design
// #Udemy_Design #Big_O_Time_O(1)_Space_O(N)
// #2024_01_11_Time_105_ms_(95.77%)_Space_55.6_MB_(13.78%)

public class MinStack {
    private class Node {
        public int min;
        public int data;
        public Node nextNode;
        public Node previousNode;

        public Node(int min, int data, Node previousNode, Node nextNode) {
            this.min = min;
            this.data = data;
            this.previousNode = previousNode;
            this.nextNode = nextNode;
        }
    }

    private Node currentNode;

    // initialize your data structure here.
    public MinStack() {
        // no initialization needed.
    }

    public void Push(int val) {
        if (currentNode == null) {
            currentNode = new Node(val, val, null, null);
        } else {
            currentNode.nextNode = new Node(Math.Min(currentNode.min, val), val, currentNode, null);
            currentNode = currentNode.nextNode;
        }
    }

    public void Pop() {
        currentNode = currentNode.previousNode;
    }

    public int Top() {
        return currentNode.data;
    }

    public int GetMin() {
        return currentNode.min;
    }
}
}
/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
