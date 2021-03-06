/*
 * @lc app=leetcode.cn id=98 lang=csharp
 *
 * [98] 验证二叉搜索树
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    //中序遍历生成一个数组，判断是不是递增数组
    IList<int> res;
    public bool IsValidBST(TreeNode root) {
        if (root == null) return true;
        res = new List<int>();
        Helper(root);
        for (int i = 0; i < res.Count - 1; i++)
        {
            if (res[i + 1] <= res[i])
            {
                return false;
            }
        }
        return true;
    }

    private void Helper(TreeNode node) {
        if (node != null)
        {
            if (node.left != null)
            {
                Helper(node.left);
            }
            res.Add(node.val);
            if (node.right != null)
            {
                Helper(node.right);
            }
        }
    }

    //递归
    // public bool IsValidBST(TreeNode root) {
    //     if (root == null) return true;
    //     return Helper(root, float.MinValue, float.MaxValue);
    // }

    // private bool Helper(TreeNode node, float min, float max) {
    //     if (node == null) return true;
    //     if (min >= node.val || node.val >= max)
    //     {
    //         return false;
    //     }
    //     return Helper(node.left, min, node.val)
    //      && Helper(node.right, node.val, max);
    // }
}
// @lc code=end

