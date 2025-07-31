/*
 * @lc app=leetcode id=1394 lang=csharp
 *
 * [1394] Find Lucky Integer in an Array
 */

// @lc code=start
public class Solution {
    public int FindLucky(int[] arr) {
        int[] map = new int[501];
        foreach (int num in arr)
        {
            map[num]++;
        }
        
        for (int i = 500; i > 0; i--)
        {
            if (i == map[i])
            {
                return i;
            }
        }

        return -1;
    }
}
// @lc code=end

