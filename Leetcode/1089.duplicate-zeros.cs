/*
 * @lc app=leetcode id=1089 lang=csharp
 *
 * [1089] Duplicate Zeros
 */

// @lc code=start
public class Solution {
    public void DuplicateZeros(int[] arr) {
        int lastIndex = arr.Length - 1;
        int zeroCount = 0, i = 0;
        for (i = 0; i < arr.Length - zeroCount; i++)
        {
            if (arr[i] == 0)
                zeroCount++;
            if (zeroCount + i >= lastIndex)
                break;
        }
        
        if (i >= arr.Length) i = arr.Length - 1;
        
        int index = arr.Length - 1;        
        if (i + zeroCount >= arr.Length)
        {
            arr[index--] = arr[i--];
        }
        for (; i >= 0; i--)
        {
            arr[index] = arr[i];
            if (arr[i] == 0)
            {
                arr[index - 1] = 0;
                index -= 2;
            }
            else
            {
                index--;
            }
        }
    }
}
// @lc code=end

