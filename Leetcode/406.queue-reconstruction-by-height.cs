/*
 * @lc app=leetcode id=406 lang=csharp
 *
 * [406] Queue Reconstruction by Height
 */

// @lc code=start
public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        Array.Sort(people, (a, b) => a[0] == b[0] ? a[1] - b[1] : b[0] - a[0]);
        
        List<int[]> list = new(people.Length);
        
        foreach (var p in people)
        {
            list.Insert(p[1], p);
        }
        
        return list.ToArray();
    }
}
// @lc code=end

