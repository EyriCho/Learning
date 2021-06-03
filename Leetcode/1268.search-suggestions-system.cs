/*
 * @lc app=leetcode id=1268 lang=csharp
 *
 * [1268] Search Suggestions System
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products);
        var result = new List<IList<string>>();
        
        int i = 0, l = 0, r = products.Length - 1;
        while (i < searchWord.Length)
        {
            while (l <= r && (i >= products[l].Length || products[l][i] != searchWord[i]))
                l++;
            
            while (l <= r && (i >= products[r].Length || products[r][i] != searchWord[i]))
                r--;
            
            var list = new List<string>();
            if (l <= r)
            {
                int j = 0;
                while (j < 3 && l + j <= r)
                {
                    list.Add(products[l + j]);
                    j++;
                }
            }
            result.Add(list);
            i++;
        }
        
        return result;
    }
}
// @lc code=end

