/*
 * @lc app=leetcode id=1275 lang=csharp
 *
 * [1275] Find Winner on a Tic Tac Toe Game
 */

// @lc code=start
public class Solution {
    public string Tictactoe(int[][] moves) {
        int[] rows = new int[3],
            cols = new int[3];
        
        int cross1 = 0, cross2 = 0;
        
        for (int i = 0; i < moves.Length; i++)
        {
            int ab = ((i & 1) == 1) ? 1 : -1;
            rows[moves[i][0]] += ab;
            cols[moves[i][1]] += ab;
            if (moves[i][0] == moves[i][1])
                cross1 += ab;
            if (moves[i][0] + moves[i][1] == 2)
                cross2 += ab;
        }
        
        for (int i = 0; i < 3; i++)
        {
            if (rows[i] == -3)
                return "A";
            if (rows[i] == 3)
                return "B";
            if (cols[i] == -3)
                return "A";
            if (cols[i] == 3)
                return "B";
        }
        
        if (cross1 == -3)
            return "A";
        if (cross1 == 3)
            return "B";
        
        if (cross2 == -3)
            return "A";
        if (cross2 == 3)
            return "B";
        
        return moves.Length == 9 ? "Draw" : "Pending";
    }
}
// @lc code=end

