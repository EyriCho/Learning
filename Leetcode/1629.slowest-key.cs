/*
 * @lc app=leetcode id=1629 lang=csharp
 *
 * [1629] Slowest Key
 */

// @lc code=start
public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {
        int max = releaseTimes[0];
        char result = keysPressed[0];
        
        for (int i = 1; i < keysPressed.Length; i++)
        {
            var duration = releaseTimes[i] - releaseTimes[i - 1];
            if (duration > max)
            {
                max = duration;
                result = keysPressed[i];
            }
            else if (duration == max && keysPressed[i] > result)
                result = keysPressed[i];
        }
        
        return result;
    }
}
// @lc code=end

