/*
 * @lc app=leetcode id=3479 lang=csharp
 *
 * [3479] Fruits Into Baskets III
 */

// @lc code=start
public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int[] segTree = new int[fruits.Length * 4];

        void BuildTree(int index, int low, int high)
        {
            if (low == high)
            {
                segTree[index] = baskets[low];
                return;
            }

            int mid = (low + high) >> 1,
                left = 2 * index + 1,
                right = 2 * index + 2;
            
            BuildTree(left, low, mid);
            BuildTree(right, mid + 1, high);

            segTree[index] = Math.Max(segTree[left], segTree[right]);
        }

        bool PlaceFruit(int index, int low, int high, int fruit)
        {
            if (segTree[index] < fruit)
            {
                return false;
            }

            if (low == high)
            {
                segTree[index] = 0;
                return true;
            }

            int mid = (low + high) >> 1,
                left = 2 * index + 1,
                right = 2 * index +2;
            
            bool found = segTree[left] >= fruit ?
                PlaceFruit(left, low, mid, fruit) :
                PlaceFruit(right, mid + 1, high, fruit);
            
            segTree[index] = Math.Max(segTree[left], segTree[right]);
            return found;
        }

        BuildTree(0, 0, fruits.Length - 1);

        int result = 0;
        foreach (int fruit in fruits)
        {
            if (!PlaceFruit(0, 0, fruits.Length - 1, fruit))
            {
                result++;
            }
        }

        return result;
    }
}
// @lc code=end

