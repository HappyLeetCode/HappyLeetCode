/*
 * @lc app=leetcode.cn id=146 lang=csharp
 *
 * [146] LRU 缓存机制
 */
// 我们以内存访问为例解释缓存的工作原理。假设缓存的大小固定，初始状态为空。
// 每发生一次读内存操作，首先查找待读取的数据是否存在于缓存中，若是，则缓存命中，返回数据；
// 若否，则缓存未命中，从内存中读取数据，并把该数据添加到缓存中。
// 向缓存添加数据时，如果缓存已满，则需要删除访问时间最早的那条数据，这种更新缓存的方法就叫做LRU。
// 实现LRU时，我们需要关注它的读性能和写性能，
// 理想的LRU应该可以在O(1)的时间内读取一条数据或更新一条数据，也就是说读写的时间复杂度都是O(1)。
// 因此，我们需要一种既按访问时间排序，又能在常数时间内随机访问的数据结构。
// 这可以通过HashMap+双向链表实现。HashMap保证通过key访问数据的时间为O(1)，
// 双向链表则按照访问时间的顺序依次穿过每个数据。之所以选择双向链表而不是单链表，
// 是为了可以从中间任意结点修改链表结构，而不必从头结点开始遍历。

// @lc code=start
public class LRUCache {
    int capacity;
    Node head, tail;
    Dictionary<int, Node> LRUDic;
    public class Node {
        public int key;
        public int value;
        public Node pre;
        public Node next;
    }
    public LRUCache(int capacity) {
        this.capacity = capacity;
        LRUDic = new Dictionary<int, Node>();
        head = new Node();
        tail = new Node();
        head.next = tail;
        tail.pre = head;
    }

    public int Get(int key) {
        if (LRUDic.ContainsKey(key))
        {
            int value = LRUDic[key].value;
            DeleteNode(LRUDic[key]);            //删除节点在链表的位
            AddNodeAtHead(LRUDic[key]);         //将节点移到链头
            return value;
        }else{
            return -1;
        }
    }

    public void Put(int key, int value) {
        if (LRUDic.ContainsKey(key))
        {
            Node node = LRUDic[key];
            DeleteNode(node);            //删除这个节点的位置
            node.value = value;
            AddNodeAtHead(node);            //将节点移到链头
            return;
        }
        //容量足够时候
        if (capacity > LRUDic.Count)
        {
            Node node = new Node();
            node.key = key;
            node.value = value;
            LRUDic.Add(key, node);
            AddNodeAtHead(node);        //将节点移到链头
        }else{
            Node node = LRUDic[tail.pre.key];
            LRUDic.Remove(DelletTail());    //LRUDic移除最后一个key
            node.key = key;
            node.value = value;
            AddNodeAtHead(node);    //将节点移到链头
            LRUDic.Add(key, node);
        }
    }

    public void DeleteNode(Node node) {
        node.pre.next = node.next;
        node.next.pre = node.pre;
    }

    public void AddNodeAtHead(Node node) {
        node.next = head.next;
        head.next.pre = node;
        head.next = node;
        node.pre = head;
    }

    public int DelletTail() {
        int key = tail.pre.key;
        Node node = tail.pre;
        node.pre.next = tail;
        tail.pre = node.pre;
        return key;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

