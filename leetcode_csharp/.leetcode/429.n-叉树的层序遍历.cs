/*
 * @lc app=leetcode.cn id=429 lang=csharp
 *
 * [429] N 叉树的层序遍历
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
    public IList<IList<int>> LevelOrder(Node root) {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0){
            IList<int> data = new List<int>();
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                Node node = queue.Dequeue();
                data.Add(node.val);
                if (node.children != null && node.children.Count > 0) {
                    foreach(var child in node.children) {
                        queue.Enqueue(child);
                    }
                }
            }
            res.Add(data);
        }
        return res;
    }







    //思路：广度优先遍历（队列）实现
    // public IList<IList<int>> LevelOrder(Node root) {
    //     IList<IList<int>> res = new List<IList<int>>();
    //     if (root == null) return res;
    //     Queue<Node> queue = new Queue<Node>();
    //     queue.Enqueue(root);
    //     while(queue.Count > 0){
    //         int size = queue.Count;
    //         List<int> data = new List<int>();
    //         for (int i = 0; i < size; i++)
    //         {
    //             Node node = queue.Dequeue();
    //             data.Add(node.val);
    //             foreach (var child in node.children)
    //             {
    //                 queue.Enqueue(child);
    //             }
    //         }
    //         res.Add(data);
    //     }
    //     return res;
    // }
}
// @lc code=end

