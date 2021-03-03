/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> dic = new Dictionary<char, char>(){ {')', '('}, {']', '['}, {'}', '{'} };
        Stack<char> st = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsValue(s[i]))
            {
                st.Push(s[i]);
            }else if (st.Count == 0 || st.Pop() != dic[s[i]])
            {
                return false;
            }
        }
        return st.Count == 0;
    }
}
// @lc code=end

