/*
 * @lc app=leetcode.cn id=84 lang=csharp
 *
 * [84] 柱状图中最大的矩形
 */

// @lc code=start
public class Solution {
    // //暴力法，左右边界,目前会超时
    // public int LargestRectangleArea(int[] heights) {
    //     if (heights == null || heights.Length == 0) return 0;
    //     int len = heights.Length;
    //     if (len == 1) return heights[0];
    //     int area = 0;
    //     for (int mid = 0; mid < len; mid++)
    //     {
    //         int height = heights[mid]; //枚举高
    //         int left = mid, right = mid;
    //         while(left - 1 >= 0 && heights[left - 1] >= heights[mid]){
    //             left--;
    //         }
    //         while(right + 1 < len && heights[right + 1] >= heights[mid]){
    //             right++;
    //         }
    //         area = Math.Max((right - left + 1) * height, area);
    //     }
    //     return area;
    // }

    //单调栈 + 哨兵
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

