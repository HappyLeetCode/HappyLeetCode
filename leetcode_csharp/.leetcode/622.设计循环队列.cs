/*
 * @lc app=leetcode.cn id=622 lang=csharp
 *
 * [622] 设计循环队列
 */

// @lc code=start
public class MyCircularQueue {
    //参考624
    //front：指向队列头部第 1 个有效数据的位置；
    // rear：指向队列尾部（即最后 1 个有效数据）的下一个位置，即下一个从队尾入队元素的位置。
    // 判别队列为空的条件是：front == rear;
    // 判别队列为满的条件是：(rear + 1) % capacity == front;。
    // 可以这样理解，当 rear 循环到数组的前面，要从后面追上 front，还差一格的时候，判定队列为满。

    private int front, rear;
    private int[] arr;
    private int capacity;
    public MyCircularQueue(int k) {
        capacity = k + 1;
        arr = new int[capacity];
        front = 0;
        rear = 0;
    }
    
    public bool EnQueue(int value) {
        if(IsFull()) return false;
        arr[rear] = value;
        rear = (rear + 1) % capacity;
        return true;
    }
    
    public bool DeQueue() {
        if(IsEmpty()) return false;
        front = (front + 1) % capacity;
        return true;
    }
    
    public int Front() {
        if(IsEmpty()) return -1;
        return arr[front];
    }
    
    public int Rear() {
        if(IsEmpty()) return -1;
        return arr[(rear - 1 + capacity) % capacity];
    }
    
    public bool IsEmpty() {
        return front == rear;
    }
    
    public bool IsFull() {
        return (rear + 1) % capacity == front;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
// @lc code=end

