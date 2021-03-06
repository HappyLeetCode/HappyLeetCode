/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
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
    IList<int> res;
    public IList<int> InorderTraversal(TreeNode root) {
        res = new List<int>();
        Helper(root);
        return res;
    }

    public void Helper(TreeNode root) {
        if (root != null)
        {
            if (root.left != null)
            {
                Helper(root.left);
            }
            res.Add(root.val);
            if (root.right != null);
            {
                Helper(root.right);
            }
        }
    }

    // public IList<int> InorderTraversal(TreeNode root) {
    //     IList<int> res = new List<int>();
    //     if(root == null)return res;
    //     Stack<TreeNode> stack = new Stack<TreeNode>();
    //     while(stack.Any() || root!= null){
    //         while(root != null){
    //             stack.Push(root);
    //             root = root.left;
    //         }
    //         root = stack.Pop();
    //         res.Add(root.val);
    //         root = root.right;
    //     }
    //     return res;
    // }

}
// @lc code=end

