/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] a = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            a[s[i] - 'a']++;
            a[t[i] - 'a']--;
        }
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != 0) return false;
        }
        return true;
    }
}
// @lc code=end

