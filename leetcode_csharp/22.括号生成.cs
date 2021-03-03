/*
 * @lc app=leetcode.cn id=22 lang=csharp
 *
 * [22] 括号生成
 */

// @lc code=start
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<String> ans = new List<String>();
        backtrack(ans, new StringBuilder(), 0, 0, n);
        return ans;
    }

    public void backtrack(List<string> ans, StringBuilder cur, int open, int close, int max) {
        if (cur.Length == max * 2)
        {
            ans.Add(cur.ToString());
            return;
        }
        if (open < max)
        {
            cur.Append("(");
            backtrack(ans, cur, open + 1, close, max);
            cur.Remove(cur.Length - 1, 1);
        }
        if (close < open)
        {
            cur.Append(")");
            backtrack(ans, cur, open, close + 1, max);
            cur.Remove(cur.Length - 1, 1);
        }
    }
}
// @lc code=end

