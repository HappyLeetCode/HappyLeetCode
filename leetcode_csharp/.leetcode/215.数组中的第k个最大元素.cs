/*
 * @lc app=leetcode.cn id=215 lang=csharp
 *
 * [215] 数组中的第K个最大元素
 */

// @lc code=start
public class Solution {
    //优先队列（堆排序），因为是求最大元素，则构建最大堆Max Heap
    public int FindKthLargest(int[] nums, int k) {
        int heapSize = nums.Length;
        BuildMaxHeap(nums, heapSize);
        for (int i = heapSize - 1; i >= heapSize - k + 1; i--)
        {
            Swap(nums, 0, i);
            --heapSize;
            MaxHeapify(nums, 0, heapSize);
        }
        return nums[0];
    }
    
    public void BuildMaxHeap(int[] a, int heapSize){
        for (int i = heapSize/2; i >= 0; i--)
        {
            MaxHeapify(a, i, heapSize);
        }
    }

    public void MaxHeapify(int[] a, int i, int heapSize){
        int l = i * 2 +1, r = i * 2 + 2, largest = i;
        if (l < heapSize && a[l] > a[largest]) largest = l;
        if (r < heapSize && a[r] > a[largest]) largest = r;
        if (largest != i)
        {
            Swap(a, i, largest);
            MaxHeapify(a, largest, heapSize);
        }
    }

    public void Swap(int[] a, int i, int j){
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }

    //解法分割线
    
    //快速排序
}
// @lc code=end

