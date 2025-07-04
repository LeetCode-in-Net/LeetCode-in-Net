namespace LeetCodeNet.G0001_0100.S0082_remove_duplicates_from_sorted_list_ii {
    
    using Xunit;
    using LeetCodeNet.Com_github_leetcode;
    public class SolutionTest {
        private ListNode BuildList(int[] vals) {
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            foreach (var v in vals) {
                curr.next = new ListNode(v);
                curr = curr.next;
            }
            return dummy.next;
        }

        private int[] ToArray(ListNode head) {
            var list = new System.Collections.Generic.List<int>();
            while (head != null) {
                list.Add(head.val);
                head = head.next;
            }
            return list.ToArray();
        }

        [Fact]
        public void DeleteDuplicates_Example1() {
            var solution = new Solution();
            var head = BuildList(new int[] {1,2,3,3,4,4,5});
            var result = solution.DeleteDuplicates(head);
            Assert.Equal(new int[] {1,2,5}, ToArray(result));
        }

        [Fact]
        public void DeleteDuplicates_Example2() {
            var solution = new Solution();
            var head = BuildList(new int[] {1,1,1,2,3});
            var result = solution.DeleteDuplicates(head);
            Assert.Equal(new int[] {2,3}, ToArray(result));
        }

        [Fact]
        public void DeleteDuplicates_AllUnique() {
            var solution = new Solution();
            var head = BuildList(new int[] {1,2,3});
            var result = solution.DeleteDuplicates(head);
            Assert.Equal(new int[] {1,2,3}, ToArray(result));
        }
    }
}
