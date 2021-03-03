using System.IO;
using System.Text.RegularExpressions;
using System;
/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        for (int i = 0, j = height.Length - 1; i < j; )
        {
            int minHeight = height[i] < height[j] ? height[i++] : height[j--];
            int width = j - i + 1;
            max = Math.Max(max, minHeight * width);
        }
        return max;
    }
}
// @lc code=end

