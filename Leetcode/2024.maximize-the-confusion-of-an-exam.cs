/*
 * @lc app=leetcode id=2024 lang=csharp
 *
 * [2024] Maximize the Confusion of an Exam
 */

// @lc code=start
public class Solution {
    public int MaxConsecutiveAnswers(string answerKey, int k) {
        int front = 0,
            result = 0,
            countT = 0,
            countF = 0;

        for (int i = 0; i < answerKey.Length; i++)
        {
            if (answerKey[i] == 'T')
            {
                countT++;
            }
            else
            {
                countF++;
            }

            while (countT > k && countF > k)
            {
                if (answerKey[front] == 'T')
                {
                    countT--;
                }
                else
                {
                    countF--;
                }
                front++;
            }

            result = Math.Max(result, i - front + 1);
        }

        return result;
    }
}
// @lc code=end

