/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution {
    //由于是有序数组，使用双指针方法。
    //这一方法将两个数组看作队列，每次从两个数组头部取出比较小的数字放到结果中。
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = 0, p2 = 0;
        int[] sorted = new int[m + n];
        int cur;
        while (p1 < m || p2 < n)
        {
            if (p1 == m)
            {
                cur = nums2[p2++];
            }else if (p2 == n)
            {
                cur = nums1[p1++];
            }else if (nums1[p1] < nums2[p2])
            {
                cur = nums1[p1++];
            }else
            {
                cur = nums2[p2++];
            }
            sorted[p1 + p2 -1] = cur;
        }
        for (int i = 0; i < m + n; i++)
        {
            nums1[i] = sorted[i];
        }
    }
    // //直接合并后排序 时间 O(m+n) 空间O(log(m+n))
    // public void Merge(int[] nums1, int m, int[] nums2, int n) {
    //     for (int i = 0; i < n; i++)
    //     {
    //         nums1[m+i] = nums2[i];
    //     }
    //     Array.Sort(nums1);
    // }
}
// @lc code=end

