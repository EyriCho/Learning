/*
 * @lc app=leetcode id=880 lang=csharp
 *
 * [880] Decoded String at Index
 */

// @lc code=start
public class Solution {
    public string DecodeAtIndex(string S, int K) {
        long length = 0, K1 = K;
        
        int i = 0;
        for (; i < S.Length && length < K; i++)
            if (S[i] > '9')
                length++;
            else
                length *= (S[i] - '0');
        
        for (--i; i >= 0; i--)
        {
            K1 %= length;
            if (K1 == 0 && S[i] > '9')
                return S[i..(i + 1)];
            
            if (S[i] > '9')
                length--;
            else
                length /= (S[i] - '0');
        }
        
        return string.Empty;
    }
}
// @lc code=end

