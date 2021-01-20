/*
 * @lc app=leetcode id=1640 lang=csharp
 *
 * [1640] Check Array Formation Through Concatenation
 */

// @lc code=start
public class Solution {
    public bool CanFormArray(int[] arr, int[][] pieces) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
            dict.Add(arr[i], i);
        
        foreach (var piece in pieces)
        {
            if (!dict.TryGetValue(piece[0], out var prevIndex))
                return false;
            
            for (int i = 1; i < piece.Length; i++)
            {
                if (!dict.TryGetValue(piece[i], out var nextIndex))
                    return false;
                if (prevIndex != nextIndex - 1)
                    return false;
                prevIndex = nextIndex;
            }
        }
        
        return true;
    }
}
// @lc code=end

