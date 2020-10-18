/*
 * @lc app=leetcode id=859 lang=csharp
 *
 * [859] Buddy Strings
 */

// @lc code=start
public class Solution {
    public bool BuddyStrings(string A, string B) {
        if (A.Length != B.Length || A.Length < 2 || B.Length < 2)
            return false;
        int i = -1, j = -1;
        int[] chars = new int[26];
        bool duplicate = false;
        for (int p = 0; p < A.Length; p++)
        {
            if (A[p] != B[p])
            {
                if (i < 0)
                    i = p;
                else if (j < 0)
                    j = p;
                else
                    return false;
            }
            else
            {
                if (chars[A[p] - 'a'] == 0)
                    chars[A[p] - 'a'] = 1;
                else
                    duplicate = true;
            }
        }
        
        if (i < 0 && j < 0)
            return duplicate;
        else if (j < 0)
            return false;
        
        return A[i] == B[j] && A[j] == B[i];
    }
}
// @lc code=end

