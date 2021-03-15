/*
 * @lc app=leetcode.cn id=33 lang=csharp
 *
 * [33] 搜索旋转排序数组
 */

// @lc code=start
public class Solution { 
    public int Search(int[] nums, int target) {
        //二分查找
        int n = nums.Length;
        if (n == 0) return -1;
        if (n == 1) return nums[0] == target ? 0 : -1;
        int l = 0, r = n - 1;
        while (l <= r)
        {
            int mid =  (l + r) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[0] <= nums[mid])
            {
                //左边有序
                if (nums[0] <= target && target < nums[mid])
                {
                    r = mid - 1;
                }else
                {
                    l = mid + 1;
                }
                
            }else
            {
                if (nums[mid] < target)
                {
                    
                }
            }
        }
    }
}
// @lc code=end

