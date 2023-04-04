/*
 * @lc app=leetcode id=881 lang=csharp
 *
 * [881] Boats to Save People
 */

// @lc code=start
public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        
        int l = 0, r = people.Length - 1,
            result = 0;
        while (l <= r)
        {
            if (l == r ||
                (people[r] + people[l] <= limit))
            {
                l++;
            }
            r--;
            result++;
        }
        return result;
    }
}
// @lc code=end

