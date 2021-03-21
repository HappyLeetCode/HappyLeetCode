/*
 * @lc app=leetcode.cn id=212 lang=csharp
 *
 * [212] 单词搜索 II
 */

// @lc code=start
public class Solution {
    public IList<string> FindWords(char[][] board, string[] words)
    {
        //组建前缀树
        foreach (var word in words)
        {
            _trie.Insert(word);
        }
        //以每个坐标为根节点开始迭代
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                FindWords(board, j, i, "", _trie);
            }
        }
        return _results;
    }
    private Trie _trie = new Trie();
    private IList<string> _results = new List<string>();

    private void FindWords(char[][] board, int x, int y, string pre, Trie node)
    {
        //不在前缀树前缀中，剪枝
        var c = board[y][x];
        var nodeNext = node.Next(c);
        if (nodeNext == null) return;

        string word = pre + c;
        //单词在前缀树中，从前缀树移除，加入结果集
        if (nodeNext.IsEnd)
        {
            _trie.Remove(word);
            _results.Add(word);
        }

        board[y][x] = '#';//标记已处理过的坐标，防止子孙节点再处理
        //迭代处理相邻坐标
        int[][] coords = { new[] { x - 1, y }, new[] { x + 1, y }, new[] { x, y - 1 }, new[] { x, y + 1 } };
        foreach (var coord in coords)
        {
            //超出坐标系，或此坐标已处理过，剪枝 TODO优化 四联通图
            if (coord[0] < 0 || coord[0] >= board[0].Length || coord[1] < 0 || coord[1] >= board.Length) continue;
            FindWords(board, coord[0], coord[1], word, nodeNext);
        }
        board[y][x] = c;//解除标记，还原
    }

    class Trie
    {
        public bool IsEnd { get; private set; }
        private int Count { get; set; }
        private Trie[] Nodes { get; } = new Trie[26];
        /** Initialize your data structure here. */
        public Trie() { }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            Trie node = this;
            foreach (var a in word)
            {
                if (node.Nodes[a - 'a'] == null)
                    node.Nodes[a - 'a'] = new Trie();
                node = node.Nodes[a - 'a'];
                node.Count++;
            }
            node.IsEnd = true;
        }

        public void Remove(string word)
        {
            Trie node = this;
            foreach (var a in word)
            {
                var nodeP = node;
                node = node.Nodes[a - 'a'];
                if (node == null)
                    return;
                node.Count--;
                if (node.Count <= 0)
                    nodeP.Nodes[a - 'a'] = null;
            }
            node.IsEnd = false;
        }

        public Trie Next(char a)
        {
            if (a == '#') return null;
            return Nodes[a - 'a'];
        }
    }
}
// @lc code=end

