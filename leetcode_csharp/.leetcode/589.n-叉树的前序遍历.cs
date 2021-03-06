/*
 * @lc app=leetcode.cn id=589 lang=csharp
 *
 * [589] N 叉树的前序遍历
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

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        IList<int> res = new List<int>();
        if (root == null) return res;
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            Node node = stack.Pop();
            res.Add(node.val);
            // 后入栈，先出 才是前序
            for (int i = node.children.Count - 1; i >= 0; i--)
            {
                stack.Push(node.children[i]);
            }
        }
        return res;
    }
}
// @lc code=end

