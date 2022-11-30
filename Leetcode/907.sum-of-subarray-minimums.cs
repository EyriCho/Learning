/*
 * @lc app=leetcode id=907 lang=csharp
 *
 * [907] Sum of Subarray Minimums
 */

// @lc code=start
public class Solution {
    public int SumSubarrayMins(int[] arr) {
        int[] l = new int[arr.Length],
            r = new int[arr.Length];
        
        for (int i = 0; i < arr.Length; i++)
        {
            int s = i - 1;
            while (s >= 0 && arr[s] >= arr[i])
            {
                s -= l[s];
            }
            l[i] = i - s;
        }
        
        var result = 0;
        for (int i = arr.Length - 1; i > -1; i--)
        {
            var s = i + 1;
            while (s < arr.Length && arr[s] > arr[i])
            {
                s += r[s];
            }
            r[i] = s - i;
            
            result = (int)((result + (long)arr[i] * l[i] * r[i]) % 1_000_000_007);
        }
        
        return result;
    }
}
// @lc code=end

