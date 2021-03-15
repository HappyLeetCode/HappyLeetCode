/*
 * @lc app=leetcode.cn id=69 lang=csharp
 *
 * [69] x 的平方根
 */

// @lc code=start
public class Solution {
    public int MySqrt(int x) {
        //牛顿迭代法(优化版)
        long r = x;
        while (r * r > x)
        {
            r = (r + x/r) /2;
        }
        return (int)r;

        // 牛顿迭代法
        // if (x == 0 || x == 1) return x;
        // double cur = 1;
        // double pre = 1;
        // while (true)
        // {
        //     cur = (cur + x / cur) * 0.5; //固定公式
        //     if (Math.Abs(cur - pre) < 1e-6) //差值小于一个极小的非负数
        //     {
        //         break;
        //     }
        //     pre = cur;
        // }
        // return (int)cur;


        // //二分查找
        // if (x == 0 || x == 1) return x;
        // double left = 0;
        // double right = x;
        // while (left <= right)
        // {
        //     double mid = (left + right) / 2;
        //     var result = mid * mid;
        //     if (result == x)
        //     {
        //         return (int)mid;
        //     }else if (result > x)
        //     {
        //         right = mid;
        //     }else
        //     {
        //         left = mid;
        //     }
        //     if ((int)left == (int)right)
        //     {
        //         break;
        //     }
        // }
        // return (int)left;
    }
}
// @lc code=end

