/*
 * @lc app=leetcode id=2418 lang=csharp
 *
 * [2418] Sort the People
 */

// @lc code=start
public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Array.Sort(heights, names);
        Array.Reverse(names);
        return names;
    }
}
// @lc code=end

