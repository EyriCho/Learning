/*
 * @lc app=leetcode id=1535 lang=csharp
 *
 * [1535] Find the Winner of an Array Game
 */

// @lc code=start
public class Solution {
    public int GetWinner(int[] arr, int k) {
        int curr = 0,
            next = 1,
            count = 0;

        while (true)
        {
            if (arr[curr] > arr[next])
            {
                count++;
                next++;
            }
            else
            {
                curr = next;
                next++;
                count = 1;
            }

            if (count == k)
            {
                return arr[curr];
            }
            if (next >= arr.Length)
            {
                return arr[curr];
            }
        }

        return 0;
    }
}
// @lc code=end

