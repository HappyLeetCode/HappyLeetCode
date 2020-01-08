/// <summary>
/// problem description: 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
/// 你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
/// </summary>
public class Solution {
    //Author:czz
    //简单解 二层循环，逐个数进行遍历，找到答案就返回对应下标
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Count(); i++){
            for(int j = i + 1; j < nums.Count(); j++){
                if(nums[i] + nums[j] == target){
                    return new int[]{i ,j};
                }
            }
        }
        return null;
    }
    //Author:czz
    //优化解（空间换时间），一是了解字典的特性，存取快耗内存，二是知道学会转换思路，利用字典这种特性实现牺牲空间性能来换取时间的性能提升
    public int[] TwoSum2(int[] nums, int target) { 
        var dic = new Dictionary<int,int>();
        
        for(int i=0; i< nums.Length; i++)
        {
            int temp = target - nums[i];
            if(dic.Keys.Contains(temp))
                return new int[]{ dic[temp], i};
            dic[nums[i]] = i;//当前数据存字典，实现空间换时间
        }
        return null;
    }

}
