/*
 * @lc app=leetcode id=941 lang=csharp
 *
 * [941] Valid Mountain Array
 */

// @lc code=start
public class Solution {
    public bool ValidMountainArray(int[] A) {
        if (arr.Length < 3)
            return false;
        if (arr[0] > arr[1])
            return false;
        
        bool isDown = false;
        
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                if (isDown)
                    return false;
            }
            else if (arr[i] < arr[i - 1])
            {
                if (!isDown)
                    isDown = true;
            }
            else
                return false;
        }
        
        return isDown;
    }
}
// @lc code=end

