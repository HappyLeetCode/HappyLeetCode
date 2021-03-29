/*
 * @lc app=leetcode.cn id=145 lang=csharp
 *
 * [145] 二叉树的后序遍历
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
 //先序遍历是中左右，调整代码顺序为 中右左， 反转result为 左右中。
 // 后序遍历是左右中
public class Solution {
    //栈
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0) {
            TreeNode node = stack.Pop();
            res.Add(node.val);
            if(node.left != null) stack.Push(node.left);
            if(node.right != null) stack.Push(node.right);
        }
        return res.Reverse().ToList();
    }
    // //递归
    // IList<int> res;
    // public IList<int> PostorderTraversal(TreeNode root) {
    //     res = new List<int>();
    //     Helper(root);
    //     return res;
    // }
    // private void Helper(TreeNode root) {
    //     if (root != null){
    //         if(root.left != null) Helper(root.left);
    //         if(root.right != null) Helper(root.right);
    //         res.Add(root.val);
    //     }
    // }
}
// @lc code=end

