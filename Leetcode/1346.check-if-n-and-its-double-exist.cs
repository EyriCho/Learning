/*
 * @lc app=leetcode id=1344 lang=csharp
 *
 * [1346] Check If N and Its Double Exist
 */

// @lc code=start
public class Solution {
    public bool CheckIfExist(int[] arr) {
        HashSet<int> set = new ();

        foreach (int num in arr)
        {
            if (set.Contains(num * 2))
            {
                return true;
            }

            if (num % 2 == 0 &&
                set.Contains(num >> 1))
            {
                return true;
            }

            set.Add(num);
        }

        return false;
    }
}
// @lc code=end

