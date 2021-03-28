/*
 * @lc app=leetcode.cn id=239 lang=csharp
 *
 * [239] 滑动窗口最大值
 */

// @lc code=start
public class Solution {
    //双向队列
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums == null || nums.Length == 0) return new int[] {};
        int len = nums.Length;
        if (k >= len) return new int[] {nums.Max()};
        LinkedList<int> deque = new LinkedList<int>();
        int[] result = new int[len - k + 1];
        for (int i = 0; i < len; i++)
        {
             // 保证从大到小 如果前面数小则需要依次弹出，直至满足要求
            while (deque.Count > 0 && nums[i] >= nums[deque.Last.Value])
            {
                deque.RemoveLast();
            }
            deque.AddLast(i);// 添加当前值对应的数组下标
            if (i - k >= deque.First.Value) deque.RemoveFirst();// 判断当前队列中队首的值是否有效
            if (i + 1 >= k) result[i- k + 1] = nums[deque.First.Value];// 当窗口长度为k时 保存当前窗口中最大值
        }
        return result;
    }
}
// @lc code=end

