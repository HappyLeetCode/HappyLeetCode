/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public class Solution {
    //动态规划
    public int MaxProfit(int[] prices) {
        int dp0 = 0; //一直不买
        int dp1 = -prices[0]; //只买入
        int dp2 = int.MinValue; //买入又卖出
        for (int i = 0; i < prices.Length; i++)
        {
            dp1 = Math.Max(dp1, dp0 - prices[i]); // 前一天也是dp1状态，或者前一天是dp0状态，今天买入一笔变成dp1状态
            dp2 = Math.Max(dp2, dp1 + prices[i]);// 前一天也是dp2状态，或者前一天是dp1状态，今天卖出一笔变成dp2状态
        }
        return Math.Max(dp2, dp0);

    }
    //一次遍历（贪心）
    // public int MaxProfit(int[] prices) {
    //     int minPrice = int.MaxValue;
    //     int maxProfit = 0;
    //     for (int i = 0; i < prices.Length; i++)
    //     {
    //         if (prices[i] < minPrice)
    //         {
    //             minPrice = prices[i];
    //         }else if (prices[i] - minPrice > maxProfit)
    //         {
    //             maxProfit = prices[i] - minPrice;
    //         }
    //     }
    //     return maxProfit;
    // }
    // 暴力
    // public int MaxProfit(int[] prices) {
    //     int res = 0;
    //     for (int i = 0; i < prices.Length - 1; i++)
    //     {
    //         for (int j = 0; j < prices.Length; j++)
    //         {
    //             int diff = prices[j] - prices[i];
    //             if (diff > res)
    //             {
    //                 res = diff;
    //             }
    //         }
    //     }
    //     return res;
    // }

}
// @lc code=end

