/*
 * @lc app=leetcode id=299 lang=csharp
 *
 * [299] Bulls and Cows
 */

// @lc code=start
public class Solution {
    public string GetHint(string secret, string guess) {
        int[] map = new int[10];
        int bulls = 0, cows = 0;
        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i])
                bulls++;
            else
            {
                int s = (int)(secret[i] - '0');
                int g = (int)(guess[i] - '0');
                cows += (map[s] < 0 ? 1 : 0) + (map[g] > 0 ? 1 : 0);    
                ++map[s];
                --map[g];
            }
        }
        
        return $"{bulls}A{cows}B";
    }
}
// @lc code=end

