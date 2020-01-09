/// <summary>
/// problem description: 我们把符合下列属性的数组 A 称作山脉：

///A.length >= 3
///存在 0 < i < A.length - 1 使得A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1]
///给定一个确定为山脉的数组，返回任何满足 A[0] < A[1] < ... A[i-1] < A[i] > A[i+1] > ... > A[A.length - 1] 的 i 的值。
///输入：[0,2,1,0]
///输出：1
/// </summary>
public class Solution {
    //定义一个int接收索引，循环数组，如果当前位置比上一位大且比之前存储索引位置的数也要大。则更新索引。执行完毕返回r
    public int PeakIndexInMountainArray(int[] A) {
        int r = 0; //索引
        for(int i = 0; i < A.Length; i++){
            if(i == 0){r = i;continue;}
            if(A[i] > A[i - 1]) r = i;
        }
        return r;
    }
    //二分查找。
    //默认定位最中间，根据最中间的值判断当前值是在峰值的左边还是右边。把计算范围的左边界或右边界改掉，重新计算中点。
        public int PeakIndexInMountainArray2(int[] A) {
        int left=0,right=A.Length-1,m=0;
        while(left<right){
            m = (left+right)/2;
            if(A[m]<A[m+1]){
                left=m+1;
            }else{
                right=m;
            }
        }
        return left;
    }
}
