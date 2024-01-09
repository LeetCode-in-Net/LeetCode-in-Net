namespace LeetCodeNet.Com_github_leetcode {

public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node() {
        this.val = 0;
    }

    public Node(int val) {
        this.val = val;
    }

    public Node(int val, Node next, Node random) {
        this.val = val;
        this.next = next;
        this.random = random;
    }

    public override string ToString() {
        List<string> result = new List<string>{};
        List<string> result2 = new List<string> {
            val.ToString()
        };
        if (random == null) {
            result2.Add("null");
        } else {
            result2.Add(random.val.ToString());
        }
        string result2String = "[" + string.Join(",", result2) + "]";
        result.Add(result2String);
        Node curr = next;
        while (curr != null) {
            List<string> result3 = new List<string> {
                curr.val.ToString()
            };
            if (curr.random == null) {
                result3.Add("null");
            } else {
                int randomIndex = 0;
                Node curr2 = this;
                while (curr2.next != null && curr2 != curr.random) {
                    randomIndex += 1;
                    curr2 = curr2.next;
                }
                result3.Add(randomIndex.ToString());
            }
            string result3String = "[" + string.Join(",", result3) + "]";
            result.Add(result3String);
            curr = curr.next;
        }
        return "[" + string.Join(",", result) + "]";
    }
}
}