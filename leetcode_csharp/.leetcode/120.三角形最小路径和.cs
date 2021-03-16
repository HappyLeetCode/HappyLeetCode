/*
 * @lc app=leetcode.cn id=120 lang=csharp
 *
 * [120] 三角形最小路径和
 */

//递归n层 left or right ,
//DP f(i, j) 表示坐标a[i, j]到最下面的最小路径和
//f(i, j) = min(f(i+1, j), f(i+1, j+1)) + a[i,j]
// @lc code=start
public class Solution {
    //DP 时间 n^2 空间 n^2
    // public int MinimumTotal(IList<IList<int>> triangle) {
    //     IList<IList<int>> dp = triangle; //直接赋值避免 +a[i, j]
    //     for (int i = triangle.Count - 2; i >= 0; i--)
    //     {
    //         for (int j = 0; j < i+1; j++)
    //         {
    //             dp[i][j] += Math.Min(dp[i+1][j], dp[i+1][j+1]);
    //         }
    //     }
    //     return dp[0][0];
    // }

    // //DP 时间 n^2 空间 n
    // public int MinimumTotal(IList<IList<int>> triangle) {
    //     int[] A = new int[triangle.Count + 1];
    //     for (int i = triangle.Count - 1; i >= 0; i--)
    //     {
    //         for (int j = 0; j < i + 1; j++)
    //         {
    //             A[j] = Math.Min(A[j], A[j+1]) + triangle[i][j];
    //         }
    //     }
    //     return A[0];
    // }
    //递归 时间 2^n; TODO优化方法：加一个cache表（level, c）缓存起来
    private int count;
    public int MinimumTotal(IList<IList<int>> triangle) {
        count = triangle.Count;
        //TODO 格式不会写
        // int[][] = new int[count][count]; 
        return helper(0, 0, triangle);
    }

    private int helper(int level, int c, IList<IList<int>> triangle) {

        //TODO 优化
        // if (mem[level][c] != null)
        // {
        //     return mem[level][c];
        // }

        if (level == count -1) return triangle[level][c];
        int left = helper(level + 1, c, triangle);
        int right = helper(level + 1, c + 1, triangle);
        return Math.Min(left, right) + triangle[level][c];
    }
}
// @lc code=end

