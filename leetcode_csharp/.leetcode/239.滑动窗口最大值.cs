/*
 * @lc app=leetcode.cn id=239 lang=csharp
 *
 * [239] 滑动窗口最大值
 */

// @lc code=start
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums == null || nums.Length == 0) return new int[] {};
        int len = nums.Length;
        if (k >= len) return new int[] {nums.Max()};
        LinkedList<int> deque = new LinkedList<int>();
        int[] result = new int[len - k + 1];
        for (int i = 0; i < len; i++)
        {
            while (deque.Count > 0 && nums[i] >= nums[deque.Last.Value])
            {
                deque.RemoveLast();
            }
            deque.AddLast(i);
            if (i - k >= deque.First.Value) deque.RemoveFirst();
            if (i + 1 >= k) result[i- k + 1] = nums[deque.First.Value];
        }
        return result;
    }
}
// @lc code=end

