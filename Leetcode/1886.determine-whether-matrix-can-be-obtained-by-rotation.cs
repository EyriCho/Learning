/*
 * @lc app=leetcode id=1886 lang=csharp
 *
 * [1886] Determine Whether Matrix Can Be Obtained By Rotation
 */

// @lc code=start
public class Solution {
    public bool FindRotation(int[][] mat, int[][] target) {
        bool success = true;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat.Length; j++)
            {
                if (mat[i][j] != target[i][j])
                {
                    success = false;
                    break;
                }
            }
        }
        if (success)
        {
            return true;
        }

        success = true;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat.Length; j++)
            {
                if (mat[i][j] != target[j][mat.Length - 1 - i])
                {
                    success = false;
                    break;
                }
            }
        }
        if (success)
        {
            return true;
        }

        success = true;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat.Length; j++)
            {
                if (mat[i][j] != target[mat.Length - 1 - i][mat.Length - 1 - j])
                {
                    success = false;
                    break;
                }
            }
        }
        if (success)
        {
            return true;
        }

        success = true;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat.Length; j++)
            {
                if (mat[i][j] != target[mat.Length - 1 - j][i])
                {
                    success = false;
                    break;
                }
            }
        }
        return success;
    }
}
// @lc code=end

