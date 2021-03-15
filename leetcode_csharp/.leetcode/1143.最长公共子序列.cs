/*
 * @lc app=leetcode.cn id=1143 lang=csharp
 *
 * [1143] 最长公共子序列
 */

// @lc code=start
public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        // 动态规划
        int m = text1.Length;
        int n = text2.Length;
        int[,] dp = new int[m+1, n+1]; //默认都为0
        for (int i = 1; i < m + 1; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1,j - 1];
                }else
                {
                    dp[i, j] = Math.Max(dp[i-1, j], dp[i, j - 1]);
                }
            }
        }
        return dp[m, n];
    }
}
// @lc code=end

