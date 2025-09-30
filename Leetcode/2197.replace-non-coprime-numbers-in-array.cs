/*
 * @lc app=leetcode id=2197 lang=csharp
 *
 * [2197] Replace Non-Coprime Numbers in Array
 */

// @lc code=start
public class Solution {
    public IList<int> ReplaceNonCoprimes(int[] nums) {
        int CommonFactor(int a, int b)
        {
            if (b > a)
            {
                b ^= a;
                a ^= b;
                b ^= a;
            }

            int left = 0;
            while (b > 1)
            {
                if (a % b == 0)
                {
                    return b;
                }

                left = a % b;
                a = b;
                b = left;
            }
            return b;
        }

        Stack<int> stack = new ();
        int num = 0,
            common = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            num = nums[i];
            while (stack.Count > 0)
            {
                common = CommonFactor(stack.Peek(), num);
                if (common == 1)
                {
                    break;
                }

                num = stack.Pop() / common * num;
            }
            stack.Push(num);
        }

        List<int> result = stack.ToList();
        result.Reverse();

        return result;
    }
}
// @lc code=end

