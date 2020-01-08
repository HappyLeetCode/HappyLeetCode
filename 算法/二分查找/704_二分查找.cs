/// <summary>
/// problem description: 给定一个 n 个元素有序的（升序）整型数组 nums 和一个目标值 target  ，写一个函数搜索 nums 中的 target，如果目标值存在返回下标，否则返回 -1。
/// </summary>
public class Solution
{
    //Author:czz
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1; // 注意

        while (left <= right)
        {
            int mid = (right + left) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1; // 注意
            else if (nums[mid] > target)
                right = mid - 1; // 注意
        }
        return -1;
    }
}
