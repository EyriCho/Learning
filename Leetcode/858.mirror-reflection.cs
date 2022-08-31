/*
 * @lc app=leetcode id=858 lang=csharp
 *
 * [858] Mirror Reflection
 */

// @lc code=start
public class Solution {
    public int MirrorReflection(int p, int q) {
        int pCount = 1, qCount = 1;
        
        while (pCount * p != qCount * q)
        {
            qCount++;
            pCount = qCount * q / p;
        }
        
        if (pCount % 2 == 1 && qCount % 2 == 0)
        {
            return 2;
        }
        else if (pCount % 2 == 1 && qCount % 2 == 1)
        {
            return 1;
        }
        else if (pCount % 2 == 0 && qCount % 2 == 1)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
}
// @lc code=end

