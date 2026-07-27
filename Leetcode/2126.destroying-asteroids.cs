/*
 * @lc app=leetcode id=2126 lang=csharp
 *
 * [2126] Destroying Asteroids
 */

// @lc code=start
public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        int[] bucket = new int[100_001];
        long sum = mass;
        mass = 0;
        foreach (int a in asteroids)
        {
            bucket[a]++;
            mass = Math.Max(mass, a);
        }

        for (int i = 1; i <= mass; i++)
        {
            if (sum < i)
            {
                return false;
            }

            sum += 1L * i * bucket[i];
        }

        return true;
    }
}
// @lc code=end

