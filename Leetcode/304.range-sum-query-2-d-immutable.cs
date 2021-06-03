/*
 * @lc app=leetcode id=304 lang=csharp
 *
 * [304] Range Sum Query 2D - Immutable
 */

// @lc code=start
public class NumMatrix {

    public NumMatrix(int[][] matrix) {
        sums = new int[matrix.Length + 1, matrix[0].Length + 1];
        
        for (int i = 1; i <= matrix.Length; i++)
            for (int j = 1; j <= matrix[0].Length; j++)
                sums[i,j] = sums[i, j - 1] + sums[i - 1, j] - sums[i - 1, j - 1] +
                    matrix[i - 1][j - 1];
    }

    int[,] sums;

    public int SumRegion(int row1, int col1, int row2, int col2) {
        return sums[row2 + 1, col2 + 1] - sums[row1, col2 + 1] - sums[row2 + 1, col1] +
            sums[row1, col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
// @lc code=end

