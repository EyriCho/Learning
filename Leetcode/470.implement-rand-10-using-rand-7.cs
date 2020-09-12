/*
 * @lc app=leetcode id=470 lang=csharp
 *
 * [470] Implement Rand10() Using Rand7()
 */

// @lc code=start
/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        while (true)
        {
            int rand49 = (Rand7() - 1) * 7 + Rand7();
            if (rand49 <= 40) return rand49 % 10 + 1;
            int rand63 = (rand49 - 41) * 7 + Rand7();
            if (rand63 <= 60) return rand63 % 10 + 1;
            int rand21 = (rand63 - 61) * 7 + Rand7();
            if (rand21 <= 20) return rand21 % 10 + 1;
        }
    }
}
// @lc code=end

