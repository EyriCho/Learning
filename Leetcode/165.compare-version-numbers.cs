/*
 * @lc app=leetcode id=165 lang=csharp
 *
 * [165] Compare Version Numbers
 */

// @lc code=start
public class Solution {
    public int CompareVersion(string version1, string version2) {
        int i1 = 0, i2 = 0;
        while (true)
        {
            int part1 = 0, part2 = 0;
            while (i1 < version1.Length && version1[i1] != '.')
                part1 = part1 * 10 + (int)(version1[i1++] - '0');
            while (i2 < version2.Length && version2[i2] != '.')
                part2 = part2 * 10 + (int)(version2[i2++] - '0');
            i1++;
            i2++;
            
            if (part1 > part2)
                return 1;
            else if (part1 < part2)
                return -1;
            
            if (i1 >= version1.Length && i2 >= version2.Length)
                break;
        }
        
        return 0;
    }
}
// @lc code=end

