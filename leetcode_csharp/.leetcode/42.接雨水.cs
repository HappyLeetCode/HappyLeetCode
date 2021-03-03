/*
 * @lc app=leetcode.cn id=42 lang=csharp
 *
 * [42] 接雨水
 */

// @lc code=start
public class Solution {
    public int Trap(int[] height) {
        int i = 0, area = 0;
        Stack<int> stack = new Stack<int>();
        while (i < height.Length)
        {
            while (stack.Count > 0 && height[i] > height[stack.Peek()])
            {
                int top = stack.Pop();
                if (stack.Count == 0) break;
                int curWidth = i - stack.Peek() - 1;
                int curHeight = Math.Min(height[i], height[stack.Peek()]) - height[top];
                area += curHeight * curWidth;
            }
            stack.Push(i++);
        }
        return area;
    }
}
// @lc code=end

