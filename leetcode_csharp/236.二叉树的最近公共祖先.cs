/*
 * @lc app=leetcode.cn id=236 lang=csharp
 *
 * [236] 二叉树的最近公共祖先
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    TreeNode ans;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        dfs(root, p, q);
        return ans;
    }

    public bool dfs(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return false;
        bool lson = dfs(root.left, p, q);
        bool rson = dfs(root.right, p, q);
        if ( (lson && rson) || ((root.val == p.val || root.val == q.val) && (lson || rson)) )
        {
            ans = root;
        }
        return lson || rson || (root.val == p.val || root.val == q.val);
    }
}
// @lc code=end

