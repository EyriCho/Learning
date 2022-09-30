/*
 * @lc app=leetcode id=1996 lang=csharp
 *
 * [1996] The Number of Weak Characters in the Game
 */

// @lc code=start
public class Solution {
    public int NumberOfWeakCharacters(int[][] properties) {
        Array.Sort(properties, (a, b) => 
            a[0] == b[0] ? a[1] - b[1] : b[0] - a[0]
        );
        
        var result = 0;
        var maxDefense = properties[0][1];
        
        for (int i = 1; i < properties.Length; i++)
        {
            if (properties[i][1] < maxDefense)
            {
                result++;
            }
            
            maxDefense = Math.Max(properties[i][1], maxDefense);
        }
        
        return result;
    }
}
// @lc code=end

