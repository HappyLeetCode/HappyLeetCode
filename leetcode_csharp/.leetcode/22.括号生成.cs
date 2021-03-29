/*
 * @lc app=leetcode.cn id=22 lang=csharp
 *
 * [22] 括号生成
 */

// @lc code=start
public class Solution {
    //回溯法
    public IList<string> GenerateParenthesis(int n) {
        IList<string> res = new List<string>();
        Helper(res, new StringBuilder(), 0, 0, n);
        return res;
    }
    private void Helper(IList<string> res, StringBuilder cur, int open, int close, int max) {
        if (cur.Length == max * 2){
            res.Add(cur.ToString());
            return;
        }
        if (open < max) {
            cur.Append("(");
            Helper(res, cur, open + 1, close, max);
            cur.Remove(cur.Length - 1, 1);
        }
        if (close < open) {
            cur.Append(")");
            Helper(res, cur, open , close + 1, max);
            cur.Remove(cur.Length - 1, 1);
        }
    }
}
// @lc code=end

