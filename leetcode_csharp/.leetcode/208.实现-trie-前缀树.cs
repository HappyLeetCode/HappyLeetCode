/*
 * @lc app=leetcode.cn id=208 lang=csharp
 *
 * [208] 实现 Trie (前缀树)
 */

// @lc code=start
public class Trie {

    /** Initialize your data structure here. */
    Trie[] nexts;
    bool isEnd;
    public Trie() {
        nexts = new Trie[26];
        isEnd = false;
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        Trie node = this;
        foreach (var c in word)
        {
            int index = c - 'a';
            if (node.nexts[index] == null)
            {
                node.nexts[index] = new Trie();
            }
            node = node.nexts[index];
        }
        node.isEnd = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        Trie node = this;
        foreach (var c in word)
        {
            int index = c - 'a';
            if (node.nexts[index] == null)
            {
                return false;
            }
            node = node.nexts[index];
        }
        return node.isEnd;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        if (prefix.Length == 0) return false;
        Trie node = this;
        foreach (var c in prefix)
        {
            int index = c - 'a';
            if (node.nexts[index] == null)
            {
                return false;
            }
            node = node.nexts[index];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
// @lc code=end

