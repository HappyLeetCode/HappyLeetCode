/// <summary>
///problem description:给你一个整数 n，请你返回 任意 一个由 n 个 各不相同 的整数组成的数组，并且这 n 个数相加和为 0 。
/// </summary>
public class Solution {

	//Author:czz
	//每一个数等于他的序号，最后一个数等于之前所有数和的负数就好了
	//例如 n=5，res = [0,1,2,3,-6]
    public int[] SumZero(int n) {
        int[] res = new int[n];
        for(int i=0;i<n-1;i++){
            res[i]=i;
            res[n-1]-=i;
        }
        return res;
    }
}
