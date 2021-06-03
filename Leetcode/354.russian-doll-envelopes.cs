/*
 * @lc app=leetcode id=354 lang=csharp
 *
 * [354] Russian Doll Envelopes
 */

// @lc code=start
public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
        Array.Sort(envelopes,
            (a, b) => 
                a[0] == b[0] ? b[1] - a[1] : a[0] - b[0]);
        
        var array = new int[envelopes.Length];
        var length = 0;
        
        foreach (var envelop in envelopes)
        {
            var index = Array.BinarySearch(array, 0, length, envelop[1]);
            if (index < 0)
                index = ~index;
            
            if (index >= length)
                array[length++] = envelop[1];
            else
                array[index] = envelop[1];
        }
        
        return length;
    }
}
// @lc code=end

