/*
 * @lc app=leetcode.cn id=155 lang=csharp
 *
 * [155] 最小栈
 */

// @lc code=start
public class MinStack {

    /** initialize your data structure here. */
    private Stack<int> st;
    private Stack<int> minStack;
    public MinStack() {
        st = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int x) {
        st.Push(x);
        if (minStack.Count == 0)
        {
            minStack.Push(x);
        }else if (minStack.Peek() >= x)
        {
            minStack.Push(x);
        }
    }
    
    public void Pop() {
        if (st.Count == 0) return;
        int min = st.Pop();
        if (min == minStack.Peek())
        {
            minStack.Pop();
        }
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

