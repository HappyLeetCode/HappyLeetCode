/*
 * @lc app=leetcode.cn id=142 lang=csharp
 *
 * [142] 环形链表 II
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode slow = head, fast = head;
        while (slow != null && fast.next != null) {
            if(fast.next.next == null) return null;
            fast = fast.next.next;
            slow = slow.next;
            if (slow == fast) {
                while (head != slow) {
                    head = head.next;
                    slow = slow.next;
                }
                return slow;
            }
        }
        return null;
    }
}
// 设 起始点到环入口 x,环入口到相遇点距离y，相遇点到环入口距离z
//slow 走过的路为 x+y, fast 走过的路为 x+y+z+y,又因为 fast是slow的两倍，
// (x+y) * 2 = x+y+z+y =>  x = z => 得出结论 从head到环起始点的距离=从相遇点到环起始的距离

// @lc code=end

