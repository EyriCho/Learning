/*
 * @lc app=leetcode id=932 lang=csharp
 *
 * [932] Beautiful Array
 */

// @lc code=start
public class Solution {
    public int[] BeautifulArray(int n) {
        var list = new List<int>();
        list.Add(1);
        while (list.Count < n)
        {
            var tmp = new List<int>();
            foreach (var num in list)
                if (num * 2 - 1 <= n)
                    tmp.Add(num * 2 - 1);
            
            foreach (var num in list)
                if (num * 2 <= n)
                    tmp.Add(num * 2);
            
            list = tmp;
        }
        
        return list.ToArray();
    }
}
// @lc code=end

