/*
 * @lc app=leetcode id=948 lang=csharp
 *
 * [948] Bag of Tokens
 */

// @lc code=start
public class Solution {
    public int BagOfTokensScore(int[] tokens, int P) {
        int result = 0;
        
        Array.Sort(tokens);
        int l = 0, r = tokens.Length - 1, score = 0;
        while (l <= r)
        {
            if (P >= tokens[l])
            {
                P -= tokens[l++];
                score++;
                if (score > result)
                    result = score;
            }
            else if (score > 0)
            {
                P += tokens[r--];
                score--;
            }
            else
                break;
        }
        
        return result;
    }
}
// @lc code=end

