/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(target - nums[i])){
                return new int[] {i, dic[target - nums[i]]};
            }else{
                dic.Add(nums[i], i);
            }
        }
        return new int[] {};
    }
}
// @lc code=end

