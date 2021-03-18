/*
 * @lc app=leetcode.cn id=198 lang=csharp
 *
 * [198] 打家劫舍
 */

// @lc code=start
public class Solution {
    //DP 时间 n
    // a[i] :0 =>1 能偷盗maxvalue: a[n -1]
    //a[i][0, 1] 0 或1 , 0:不偷 1，偷
    //a[i][0] = max(a[i - 1][0], a[i-1][1])
    //a[i][1] = a[i-1][0] + nums[i]
    // public int Rob(int[] nums) {
    //     if (nums == null || nums.Length == 0) return 0;
    //     if (nums.Length == 1) return 1;
    //     int n = nums.Length;
    //     int[,] a = new int[n, 2];
    //     a[0, 0] = 0;
    //     a[0, 1] = nums[0];
    //     for (int i = 1; i < n; i++)
    //     {
    //         a[i, 0] = Math.Max(a[i-1, 0], a[i-1, 1]);
    //         a[i, 1] = a[i-1,0] + nums[i];
    //     }
    //     return Math.Max(a[n-1, 0], a[n-1, 1]);
    // }

    //a[i]: 0 ..i，且nums[i]必偷的最大值
    //a[i] = max(a[i -1], a[i -2] + nums[i])
    // public int Rob(int[] nums) {
    //     if (nums == null || nums.Length == 0) return 0;
    //     if (nums.Length == 1) return 1;
    //     int n = nums.Length;
    //     int[] a = new int[n];
    //     a[0] = nums[0];
    //     a[1] = Math.Max(nums[0], nums[1]);
    //     int res = Math.Max(a[0], a[1]);
    //     for (int i = 2; i < n; i++)
    //     {
    //         a[i] = Math.Max(a[i-1], a[i-2] + nums[i]);
    //         res = Math.Max(res, a[i]);
    //     }
    //     return res;
    // }
    //Math.Max(a[i-1], a[i-2] + nums[i]) 推出=> 斐波拉契优化版本
    public int Rob(int[] nums) {
        int preMax = 0;
        int curMax = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = curMax;
            curMax = Math.Max(curMax, preMax + nums[i]);
            preMax = temp;
        }
        return curMax;
    }
}
// @lc code=end

