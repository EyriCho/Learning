/*
 * @lc app=leetcode id=658 lang=csharp
 *
 * [658] Find K Closest Elements
 */

// @lc code=start
public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        if (k == arr.Length)
            return arr;
        
        var xIndex = Array.BinarySearch(arr, x);
        if (xIndex < 0)
            xIndex = ~xIndex;
        int l = Math.Max(0, xIndex - k / 2);
        int r = l + k;
        if (r > arr.Length)
        {
            r = arr.Length;
            l = r - k;
        }
        
        while (true)
        {
            if (l > 0 && Math.Abs(arr[l - 1] - x) <= Math.Abs(arr[r - 1] - x))
            {
                l--;
                r--;
                continue;
            }
            
            if (r < arr.Length && Math.Abs(arr[r] - x) < Math.Abs(arr[l] - x))
            {
                l++;
                r++;
                continue;
            }
            
            break;
        }
        
        return arr[l..r];
    }
}
// @lc code=end

