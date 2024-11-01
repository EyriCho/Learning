/*
 * @lc app=leetcode id=1813 lang=csharp
 *
 * [1813] Sentence Similarity III
 */

// @lc code=start
public class Solution {
    public bool AreSentencesSimilar(string sentence1, string sentence2) {
        string[] array1 = sentence1.Split(' '),
            array2 = sentence2.Split(' ');

        int l1 = 0, r1 = array1.Length - 1,
            l2 = 0, r2 = array2.Length - 1;
        
        while (l1 <= r1 &&
            l2 <= r2 &&
            array1[l1] == array2[l2])
        {
            l1++;
            l2++;
        }

        while (l1 <= r1 &&
            l2 <= r2 &&
            array1[r1] == array2[r2])
        {
            r1--;
            r2--;
        }

        return l1 > r1 || l2 > r2;
    }
}
// @lc code=end

