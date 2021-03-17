/*
 * @lc app=leetcode.cn id=322 lang=csharp
 *
 * [322] 零钱兑换
 */

// @lc code=start
public class Solution {
    //BFS 广度优先遍历树
    //类似走楼梯 coins = [1,2,5] ,amount = 11,
    //转换成 f(n): 走到n层的最小走法数， f(11) = f(10) + 1 + f(9) + 1 + f(6) + 1,
    //推导出，最早第一次发现数值为0的结点，遍历的层数就是最少的硬币个数
    // public int CoinChange(int[] coins, int amount) {
    //     int[] dp = new int[amount + 1];//初始化数组，大小为amount + 1
    //     Array.Fill(dp, -1);//全部元素初始化为1
    //     dp[0] = 0; //金额0 的最优解dp[0] = 0
    //     //i从1 循环到amount, 依次计算金额1到amount的最优解
    //     for (int i = 1; i <= amount; i++)
    //     {
    //         //对于每个金额i，使用变量j遍历面值coins数组
    //         for (int j = 0; j < coins.Length; j++)
    //         {
    //             //所有小于等于i的面值coins[j], 如果i-coins[j] 有最优解
    //             if (coins[j] <= i && dp[i - coins[j]] != -1)
    //             {
    //                 //如果当前金额还未计算或者dp[i]比正在计算的最优解大
    //                 if (dp[i] == -1 || dp[i] > dp[i - coins[j]] + 1)
    //                 {
    //                     dp[i] = dp[i - coins[j]] + 1;
    //                 }
    //             }
    //         }
    //     }
    //     return dp[amount];
    // }


    //动态规划 斐波拉契
    //例：coins = [1, 2, 3], amount = 6
    // 定义 F(i) 为组成金额 ii 所需最少的硬币数量，假设在计算 F(i) 之前，我们已经计算出 F(0)到F(i-1) 的答案
    // 由于要硬币数量最少，所以 F(i) 为前面能转移过来的状态的最小值加上枚举的硬币数量 1 。
    //  f(n) = min{f(n - k), for k in [1,2,3]} + 1
    // F(3) = min( F(3-c1),F(3-c2),F(3-c3) ) + 1
    //      = min(F(3- 1), F(3-2), F(3-3)) + 1
    //      = min(F(2), F(1), F(0)) + 1
    //      = 1
    // public int CoinChange(int[] coins, int amount) {
    //     int[] dp = new int[amount + 1];//初始化数组，大小为amount + 1
    //     // Array.Fill(dp, -1);//全部元素初始化为1
    //     dp[0] = 0; //金额0 的最优解dp[0] = 0
    //     //i从1 循环到amount, 依次计算金额1到amount的最优解
    //     for (int i = 1; i <= amount; i++)
    //     {
    //         //对于每个金额i，使用变量j遍历面值coins数组
    //         for (int j = 0; j < coins.Length; j++)
    //         {
    //             if (coins[j] <= i)
    //             {
    //                 dp[i] = Math.Min(dp[i], dp[i-coins[j]] + 1);
    //             }


    //             // //所有小于等于i的面值coins[j], 如果i-coins[j] 有最优解
    //             // if (coins[j] <= i && dp[i - coins[j]] != -1)
    //             // {
    //             //     //如果当前金额还未计算或者dp[i]比正在计算的最优解大
    //             //     if (dp[i] == -1 || dp[i] > dp[i - coins[j]] + 1)
    //             //     {
    //             //         dp[i] = dp[i - coins[j]] + 1;
    //             //     }
    //             // }
    //         }
    //     }
    //     return dp[amount] > amount ? -1 : dp[amount];
    // }

    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];//初始化数组，大小为amount + 1
        Array.Fill(dp, -1);//全部元素初始化为1
        dp[0] = 0; //金额0 的最优解dp[0] = 0
        //i从1 循环到amount, 依次计算金额1到amount的最优解
        for (int i = 1; i <= amount; i++)
        {
            //对于每个金额i，使用变量j遍历面值coins数组
            for (int j = 0; j < coins.Length; j++)
            {
                //所有小于等于i的面值coins[j], 如果i-coins[j] 有最优解
                if (coins[j] <= i && dp[i - coins[j]] != -1)
                {
                    //如果当前金额还未计算或者dp[i]比正在计算的最优解大
                    if (dp[i] == -1 || dp[i] > dp[i - coins[j]] + 1)
                    {
                        dp[i] = dp[i - coins[j]] + 1;
                    }
                }
            }
        }
        return dp[amount];
    }
}
// @lc code=end

