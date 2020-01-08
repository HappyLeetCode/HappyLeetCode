using System;

/// <summary>
/// problem description: 给你一个整数数组 arr，请你帮忙统计数组中每个数的出现次数。
///如果每个数的出现次数都是独一无二的，就返回 true；否则返回 false。///
 </summary>
public class Solution {
    //Author:czz
    public bool UniqueOccurrences(int[] arr) {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < arr.Count(); i++){
            if(!dict.ContainsKey(arr[i])){
                dict.Add(arr[i], 0);
            }
            dict[arr[i]]++;
        }

        var hashSet = new HashSet<int>();
        foreach(var pair in dict){
            if(hashSet.Contains(pair.Value)){
                return false;
            }
            hashSet.Add(pair.Value);
        }
        return true;
    }
}
