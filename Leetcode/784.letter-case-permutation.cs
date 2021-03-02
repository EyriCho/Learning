/*
 * @lc app=leetcode id=784 lang=csharp
 *
 * [784] Letter Case Permutation
 */

// @lc code=start
public class Solution {
    public IList<string> LetterCasePermutation(string S) {
        var result = new List<string>();
        LetterCasePermutation(S.ToCharArray(), 0, result);
        return result;
    }
    
    private void LetterCasePermutation(char[] a, int index, IList<string> result)
    {
        if (index >= a.Length)
        {
            result.Add(new string(a));
            return;
        }
        
        if (a[index] > '9')
        {
            a[index] = char.ToLower(a[index]);
            LetterCasePermutation(a, index + 1, result);
            a[index] = char.ToUpper(a[index]);
        }
        LetterCasePermutation(a, index + 1, result);
    }
}
// @lc code=end

