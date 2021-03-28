/*
 * @lc app=leetcode.cn id=641 lang=csharp
 *
 * [641] 设计循环双端队列
 */

// @lc code=start
public class MyCircularDeque {
    // 这道题的前导题目是622
    //1.设计head，tail指针变量，2.head==tail成立的时候队列为空，3.tail + 1= head
    //front：指向队列头部第 11 个有效数据的位置
    //rear：指向队列尾部（即最后 11 个有效数据）的 下一个位置，即下一个从队尾入队元素的位置。
    /** Initialize your data structure here. Set the size of the deque to be k. */
    private int capacity;
    private int[] arr;
    private int head;
    private int tail;
    public MyCircularDeque(int k) {
        capacity = k + 1;
        arr = new int[capacity];
        head = 0;
        tail = 0;
    }
    
    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value) {
        if(IsFull()) return false;
        head = (head - 1 + capacity) % capacity;
        arr[head] = value;
        return true;
    }
    
    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value) {
        if(IsFull()) return false;
        tail = (tail + 1) % capacity;
        return true;
    }
    
    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront() {
        if(IsEmpty()) return false;
        head = (head + 1) % capacity;
        return true;
    }
    
    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast() {
        if(IsEmpty()) return false;
        tail = (tail - 1 + capacity) % capacity;
        return true;
    }
    
    /** Get the front item from the deque. */
    public int GetFront() {
        if(IsEmpty()) return -1;
        return arr[head];
    }
    
    /** Get the last item from the deque. */
    public int GetRear() {
        if(IsEmpty()) return -1;
        return arr[tail];
    }
    
    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {
        return tail == head;
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return (tail + 1) % capacity == head;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
// @lc code=end

