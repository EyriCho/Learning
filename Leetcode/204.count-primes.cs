/*
 * @lc app=leetcode id=204 lang=csharp
 *
 * [204] Count Primes
 */

// @lc code=start
public class Solution {
    public int CountPrimes(int n) {
        if (n < 2)
            return 0;
        
        var notPrime = new bool[n];
        
        var result = n - 2;
        for (int i = 2; i * i < n; i++)
        {
            if (notPrime[i])
                continue;
            
            for (int j = i * i; j < n; j += i)
            {
                if (notPrime[j])
                    continue;
                notPrime[j] = true;
                result--;
            }
        }
        
        return result;
    }
}
// @lc code=end

