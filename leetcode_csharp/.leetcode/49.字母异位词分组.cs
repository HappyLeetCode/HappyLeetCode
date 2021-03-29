/*
 * @lc app=leetcode.cn id=49 lang=csharp
 *
 * [49] 字母异位词分组
 */

// @lc code=start
public class Solution {
    //字母异位词的特点就是每个字符出现的次数相同，所以哈希算法输出一个字符串a的次数 b的次数
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, IList<string>>();
        foreach (var s in strs)
        {
            var key = CalKey(s);
            if (dic.ContainsKey(key)) dic[key].Add(s);
            else dic.Add(key, new List<string> { s });
        }
        return dic.Select(x => x.Value).ToList();
    }
    private string CalKey(string word){
        var map = new int[26];
        foreach (var c in word){
            map[c - 'a']++;
        }
        return string.Join(' ', map);
    }
    // public IList<IList<string>> GroupAnagrams(string[] strs) {
    //     if (strs == null || strs.Length <= 0) return new List<IList<string>>();
    //     Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
    //     for (int i = 0; i < strs.Length; i++)
    //     {
    //         char[] arr = strs[i].ToCharArray();
    //         Array.Sort(arr);
    //         string key = new string(arr); //排序后的数组转换成字符串，得到唯一的key
    //         if (dic.ContainsKey(key))
    //         {
    //             dic[key].Add(strs[i]);
    //         }else{
    //             dic.Add(key, new List<string>(){strs[i]});
    //         }
    //     }
    //     return new List<IList<string>>(dic.Values);
    // }
}
// @lc code=end

