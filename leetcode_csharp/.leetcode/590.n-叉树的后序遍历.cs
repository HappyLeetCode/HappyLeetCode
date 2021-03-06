/*
 * @lc app=leetcode.cn id=590 lang=csharp
 *
 * [590] N 叉树的后序遍历
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    IList<int> res;
    public IList<int> Postorder(Node root) {
        res = new List<int>();
        if (root == null ) return res;
        Helper(root);
        return res;
    }

    private void Helper(Node node) {
        if (node != null)
        {
            for (int i = 0; i < node.children.Count; i++)
            {
                Helper(node.children[i]);
            }
            res.Add(node.val);
        }
    }
}
// @lc code=end

