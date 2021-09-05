/*
 * @lc app=leetcode id=927 lang=csharp
 *
 * [927] Three Equal Parts
 */

// @lc code=start
public class Solution {
    public int[] ThreeEqualParts(int[] arr) {
        int countOne = 0;
        foreach (var a in arr)
            countOne += a;
        if (countOne == 0)
            return new int[] { 0, arr.Length - 1 };;
        if (countOne % 3 != 0)
            return new int[] { -1 , -1 };
        
        int k = countOne / 3;
        countOne = 0;
        int f = 0, s = 0, t = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
                continue;
            if (countOne == 0)
                f = i;
            countOne++;
            if (countOne == k + 1)
                s = i;
            if (countOne == k * 2 + 1)
            {
                t = i;
                break;
            }
        }
        
        while (t < arr.Length && arr[f] == arr[s] && arr[f] == arr[t])
        {
            f++;
            s++;
            t++;
        }


        if (t == arr.Length)
            return new int[] { f - 1, s };
        return new int[] { -1, -1 };
    }
}
// @lc code=end

