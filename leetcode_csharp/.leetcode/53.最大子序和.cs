/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子序和
 */

// @lc code=start
public class Solution {
    // DP 求子问题：max_sum(i) = math(max_sum(i -1), 0) + a[i]
    //最大子序和= 当前元素自身最大 或 包含之前后最大
    //时间 n 空间 n
    public int MaxSubArray(int[] nums) {
        int[] dp = nums;
        for (int i = 1; i < nums.Length; i++)
        {
            dp[i] = Math.Max(nums[i], nums[i] + dp[i - 1]);
        }
        return dp.Max(); // 求数组最大值
    }
    //时间 n 空间 1
    public int MaxSubArray(int[] nums) {
        int pre = 0, maxAns = nums[0];
        foreach (int x in nums) {
            pre = Math.Max(pre + x, x);
            maxAns = Math.Max(maxAns, pre);
        }
        return maxAns;
    }

    // // 暴力 n^2 TODO优化（起点和重点必须是正数）
    // public int MaxSubArray(int[] nums) {
    //     int max = int.MinValue;
    //     int len = nums.Length;
    //     for (int i = 0; i < len; i++)
    //     {
    //         int sum = 0;
    //         for (int j = i; j < len; j++)
    //         {
    //             sum += nums[j];
    //             if (sum > max)
    //             {
    //                 max = sum;
    //             }
    //         }
    //     }
    //     return max;
    // }
}
// @lc code=end

