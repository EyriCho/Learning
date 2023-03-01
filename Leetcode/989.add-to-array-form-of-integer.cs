/*
 * @lc app=leetcode id=989 lang=csharp
 *
 * [989] Add to Array-Form of Integer
 */

// @lc code=start
public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        var list = new List<int>(num.Length);

        var carry = k;
        int i = num.Length - 1;

        while (i >= 0 || carry > 0)
        {
            if (i >= 0)
            {
                carry += num[i--];
            }
            list.Add(carry % 10);
            carry /= 10;
        }

        list.Reverse();
        return list;
    }
}
// @lc code=end

