/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
public class Solution {
    public int ClimbStairs(int n) {
        if (n < 3)
        {
            return n;
        }
        int j = 2, f1 = 1, f2 = 2, f3 = 3;
        while (j < n)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            j++;
        }
        return f3;
    }
}
// @lc code=end

