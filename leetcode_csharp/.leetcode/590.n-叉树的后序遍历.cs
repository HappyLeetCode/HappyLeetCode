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
//中左右（前序） =》 中右左 =》 （反转）左右中
//左右中
public class Solution {
    public IList<int> Postorder(Node root) {
        IList<int> res = new List<int>();
        if (root == null) return res;
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            Node node = stack.Pop();
            res.Add(node.val);
            for (int i = 0; i < node.children.Count; i++)
            {
                if (node.children[i] != null)
                {
                    stack.Push(node.children[i]);
                }
            }
        }
        return res.Reverse().ToList();
    }

    // //递归
    // IList<int> res;
    // public IList<int> Postorder(Node root) {
    //     res = new List<int>();
    //     if (root == null ) return res;
    //     Helper(root);
    //     return res;
    // }

    // private void Helper(Node node) {
    //     if (node != null)
    //     {
    //         for (int i = 0; i < node.children.Count; i++)
    //         {
    //             Helper(node.children[i]);
    //         }
    //         res.Add(node.val);
    //     }
    // }
}
// @lc code=end

