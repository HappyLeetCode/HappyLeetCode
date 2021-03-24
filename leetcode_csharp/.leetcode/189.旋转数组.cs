/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 */

// @lc code=start
public class Solution {
    //时间n 空间n
    // public void Rotate(int[] nums, int k) {
    //     int len = nums.Length;
    //     int[] newArr = new int[len];
    //     for (int i = 0; i < len; i++)
    //     {
    //         newArr[(i + k) % len] = nums[i];
    //     }
    //      Array.Copy(newArr, 0, nums, 0, len);
    // }
    //时间n 空间1，先反转全部数组，在反转前k个，最后在反转剩余的
    public void Rotate(int[] nums, int k) {
        
        //4.三次反转
        k %= nums.Length;
        reverse(nums, 0, nums.Length - 1);
        reverse(nums, 0, k - 1);
        reverse(nums, k, nums.Length - 1);
    }


    public void reverse(int[] nums, int start, int end)
    {
        while(start < end)
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
// @lc code=end

