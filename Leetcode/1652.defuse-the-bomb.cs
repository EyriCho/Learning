/*
 * @lc app=leetcode id=1652 lang=csharp
 *
 * [1652] Defuse the Bomb
 */

// @lc code=start
public class Solution {
    public int[] Decrypt(int[] code, int k) {
        if (k == 0)
        {
            Array.Fill(code, 0);
            return code;
        }

        int[] result = new int[code.Length];
        int current = k < 0 ? (code.Length + k) : 1,
            next = k < 0 ? (code.Length - 1) : k,
            sum = 0;

        for (int i = current; i <= next; i++)
        {
            sum += code[i];
        }

        next = (next + 1) % code.Length;

        for (int i = 0; i < code.Length; i++)
        {
            result[i] = sum;

            sum += code[next++] - code[current++];
            next %= code.Length;
            current %= code.Length;
        }

        return result;
    }
}
// @lc code=end

