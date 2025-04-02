/*
 * @lc app=leetcode id=1352 lang=csharp
 *
 * [1352] Product of the Last K Numbers
 */

// @lc code=start
public class ProductOfNumbers {

    List<int> products;
    int zero = -1;
    int current;

    public ProductOfNumbers() {
        products = new ();
        current = 1;
    }
    
    public void Add(int num) {
        if (num == 0)
        {
            zero = products.Count;
            current = 1;
            products.Add(1);
        }
        else
        {
            products.Add(current);
            current *= num;
        }
    }
    
    public int GetProduct(int k) {
        if (zero == -1 || products.Count - k > zero)
        {
            return current / products[^k];
        }
        else
        {
            return 0;
        }
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */
// @lc code=end

