/*
 * @lc app=leetcode id=1344 lang=csharp
 *
 * [1346] Check If N and Its Double Exist
 */

// @lc code=start
public class Solution {
    public bool CheckIfExist(int[] arr) {
        if (arr == null || arr.Length == 0) return false;
        
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (dict.ContainsKey(arr[i] * 2) || 
               (arr[i] % 2 == 0 && dict.ContainsKey(arr[i] / 2)))
                return true;
            dict[arr[i]] = i;
        }
        return false;
    }
}
// @lc code=end

