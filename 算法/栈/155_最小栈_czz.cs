/// <summary>
///设计一个支持 push，pop，top 操作，并能在常数时间内检索到最小元素的栈。

///push(x) -- 将元素 x 推入栈中。
///pop() -- 删除栈顶的元素。
///top() -- 获取栈顶元素。
///getMin() -- 检索栈中的最小元素。
///
public class MinStack {
    List<int> stack = new List<int>();
    public int min = int.MaxValue;
    public int value = 0;
    /** initialize your data structure here. */
    public MinStack() {
        stack.Clear();
    }
    
    public void Push(int x) {
        stack.Add(x);
        if(x < min){
            min = x;
        }
    }
    
    public void Pop() {
        value = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        if(value == min){
            SetMin();
        }
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    private void SetMin(){
        min = int.MaxValue;
        foreach(var item in stack){
            if(item <= min){
                min = item;
            }
        }
    }

    public int GetMin() {
        return min;
    }
}