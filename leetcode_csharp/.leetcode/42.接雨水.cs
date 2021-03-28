/*
 * @lc app=leetcode.cn id=42 lang=csharp
 *
 * [42] 接雨水
 */

// @lc code=start
public class Solution {
    //暴力法
    public int Trap(int[] height) {
        int area = 0;
        int size = height.Length;
        for (int i = 1; i < size - 1; i++)
        {
            int max_left = 0, max_right = 0;
            for (int j = i; j >= 0; j--)
            {
                max_left = Math.Max(max_left, height[j]);
            }
            for (int j = i; j < size; j++)
            {
                max_right = Math.Max(max_right, height[j]);
            }
            area += Math.Min(max_left, max_right) - height[i];
        }
        return area;
    }

    //单调递减栈
    // public int Trap(int[] height) {
    //     int i = 0, area = 0;
    //     Stack<int> stack = new Stack<int>();// 栈存储数组的索引下标
    //     while (i < height.Length)
    //     {
    //         while (stack.Count > 0 && height[i] > height[stack.Peek()])
    //         {
    //             int top = stack.Pop();
    //             if (stack.Count == 0) break;
    //             int curWidth = i - stack.Peek() - 1;
    //             int curHeight = Math.Min(height[i], height[stack.Peek()]) - height[top];
    //             area += curHeight * curWidth;
    //         }
    //         stack.Push(i++);
    //     }
    //     return area;
    // }
}
// @lc code=end

