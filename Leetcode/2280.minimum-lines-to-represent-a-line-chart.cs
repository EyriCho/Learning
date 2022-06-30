/*
 * @lc app=leetcode id=2280 lang=csharp
 *
 * [2280] Minimum Lines to Represent a Line Chart
 */

// @lc code=start
public class Solution {
    public int MinimumLines(int[][] stockPrices) {
        Array.Sort(stockPrices, (a, b) => a[0] - b[0]);
        
        int Divisor (int a, int b)
        {
            int temp;
            
            a = Math.Abs(a);
            b = Math.Abs(b);
            
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            
            
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            
            return a;
        }
        
        int diffX = int.MaxValue, diffY = int.MaxValue;
        var result = 0;
        
        for (int i = 1; i < stockPrices.Length; i++)
        {
            int x = stockPrices[i][0] - stockPrices[i - 1][0],
                y = stockPrices[i][1] - stockPrices[i - 1][1];
            
            var d = Divisor(x, y);
            x /= d;
            y /= d;
            
            if (x != diffX || y != diffY)
            {
                result++;
                diffX = x;
                diffY = y;
            }
        }
        
        return result;
    }
}
// @lc code=end

