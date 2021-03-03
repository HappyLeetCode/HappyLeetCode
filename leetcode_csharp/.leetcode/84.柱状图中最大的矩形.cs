/*
 * @lc app=leetcode.cn id=84 lang=csharp
 *
 * [84] 柱状图中最大的矩形
 */

// @lc code=start
public class Solution {
    public int LargestRectangleArea(int[] heights) {
        if (heights == null || heights.Length == 0) return 0;
        int len = heights.Length;
        if (len == 1) return heights[0];
        int[] newHeights = new int[len + 2];
        newHeights[0] = 0;
        Array.Copy(heights, 0, newHeights, 1, len);
        newHeights[len + 1] = 0;
        heights = newHeights;
        len += 2;
        int area = 0;

        Stack<int> stack = new Stack<int>();
        stack.Push(0);
        
        for (int i = 0; i < len; i++)
        {
            while (heights[stack.Peek()] > heights[i])
            {
                int height = heights[stack.Pop()];
                int width = i - stack.Peek() - 1;
                area = Math.Max(area, height * width);
            }
            stack.Push(i);
        }
        return area;
    }
}
// @lc code=end

