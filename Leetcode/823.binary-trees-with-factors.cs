/*
 * @lc app=leetcode id=823 lang=csharp
 *
 * [823] Binary Trees With Factors
 */

// @lc code=start
public class Solution {
    public int NumFactoredBinaryTrees(int[] arr) {
        Array.Sort(arr);
        int result = 0;
        var dict = new Dictionary<int, int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            dict[arr[i]] = 1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] % arr[j] == 0)
                {
                    var mul = arr[i] / arr[j];
                    if (dict.ContainsKey(mul))
                    {
                        dict[arr[i]] = (int)((dict[arr[i]] + (long)dict[arr[j]] * dict[mul]) % 1_000_000_007);
                    }
                }    
            }
            
            result = (result + dict[arr[i]]) % 1_000_000_007;
        }
        
        return result;
    }
}
// @lc code=end

