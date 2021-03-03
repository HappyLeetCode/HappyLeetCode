/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        int len = nums.Length;
        if (len < 3) return result;
        Array.Sort(nums);
        for (int k = 0; k < len - 2; k++)
        {
            if (nums[k] > 0) break;
            if (k > 0 && nums[k] == nums[k - 1]) continue;
            int i = k + 1, j = len - 1;
            while (i < j)
            {
                int sum = nums[k] + nums[i] + nums[j];
                if (sum == 0)
                {
                    result.Add(new List<int>() {nums[k], nums[i], nums[j]});
                    while (i < j && nums[i] == nums[i + 1]) i++;
                    while (i < j && nums[j] == nums[j - 1]) j--;
                    i++;
                    j--;
                }
                else if (sum < 0) i++;
                else if (sum > 0) j--;
            }
        }
        return result;
    }
}
// @lc code=end

