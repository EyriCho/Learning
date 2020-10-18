/*
 * @lc app=leetcode id=1291 lang=csharp
 *
 * [1291] Sequential Digits
 */

// @lc code=start
public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        var result = new List<int>();
        for (int i = 1; i <=9 ;i++)
        {
            var last = i+1; //10
            var sum = i; 
            while (sum <= high) // 12 < 300
            {
                if (last >= 10)
                {
                    break;
                }

                sum = sum * 10 + last; // 120 + 3 == 123
                last++; //4
                if (sum >= low && sum <= high)
                {
                    result.Add(sum);
                }
            }
        }
        result.Sort();
        return result;
    }
}
// @lc code=end

