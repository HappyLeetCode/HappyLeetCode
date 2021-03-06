/*
 * @lc app=leetcode.cn id=105 lang=csharp
 *
 * [105] 从前序与中序遍历序列构造二叉树
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
    //递归 先序遍历的顺序是根节点，左子树，右子树。中序遍历的顺序是左子树，根节点，右子树。
    //所以我们只需要根据先序遍历得到根节点，然后在中序遍历中找到根节点的位置，它的左边就是左子树的节点，右边就是右子树的节点。
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length != inorder.Length) return null;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++)
        {
            dic.Add(inorder[i], i);
        }
        return BuilderTreeHelper(preorder, 0, preorder.Length, 0, inorder.Length, dic);
    }
    private TreeNode BuilderTreeHelper(int[] preorder, int p_start, int p_end, int i_start, int i_end, Dictionary<int, int> dic) {
        if (p_start == p_end) return null;
        int root_val = preorder[p_start];
        TreeNode root = new TreeNode(root_val);
        int i_root_index = dic[root_val];
        int leftNum = i_root_index - i_start;
        root.left = BuilderTreeHelper(preorder, p_start + 1, p_start + leftNum + 1, i_start, i_root_index, dic);
        root.right = BuilderTreeHelper(preorder, p_start + leftNum + 1, p_end, i_root_index + 1, i_end, dic);
        return root;
    }

}

// @lc code=end

