/*
 * @lc app=leetcode.cn id=367 lang=csharp
 *
 * [367] 有效的完全平方数
 */

// @lc code=start
public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num == 0 || num == 1) return true;
        long left = 2;
        long right = num / 2;
        long mid = 0;
        long guessSquared = 0;
        while (left <= right)
        {
            mid = left + (right - left) /2;
            guessSquared = mid * mid;
            if (guessSquared == num)
            {
                return true;
            }
            if (guessSquared > num)
            {
                right = mid - 1;
            }else
            {
                left = mid + 1;
            }
        }
        return false;
    }
}
// @lc code=end

