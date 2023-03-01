/*
 * @lc app=leetcode id=427 lang=csharp
 *
 * [427] Construct Quad Tree
 */

// @lc code=start
/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    public Node Construct(int[][] grid) {
        Node Build(int x, int y, int length)
        {
            if (length == 1)
            {
                return new Node(grid[x][y] == 1, true);
            }

            var subLength = length >> 1;
            var topLeft = Build(x, y, subLength);
            var bottomLeft = Build(x + subLength, y, subLength);
            var topRight = Build(x, y + subLength, subLength);
            var bottomRight = Build(x + subLength, y + subLength, subLength);

            if (topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf)
            {
                if (topLeft.val && topRight.val && bottomLeft.val && bottomRight.val)
                {
                    return new Node(true, true);
                }

                if (!(topLeft.val || topRight.val || bottomLeft.val || bottomRight.val))
                {
                    return new Node(false, true);
                }
            }

            return new Node(true, false, topLeft, topRight, bottomLeft, bottomRight);
        }

        return Build(0, 0, grid.Length);
    }
}
// @lc code=end

