/*
 * @lc app=leetcode id=3484 lang=csharp
 *
 * [3484] Design Spreedsheet
 */

// @lc code=start
public class Spreadsheet {

    Dictionary<string, int> table;

    public Spreadsheet(int rows) {
        table = new ();    
    }
    
    public void SetCell(string cell, int value) {
        table[cell] = value;
    }
    
    public void ResetCell(string cell) {
        table.Remove(cell);
    }
    
    public int GetValue(string formula) {
        int plus = formula.IndexOf('+');
        string X = formula[1..plus],
            Y = formula[(plus + 1)..];

        int a = Char.IsDigit(X[0]) ? int.Parse(X) : table.GetValueOrDefault(X),
            b = Char.IsDigit(Y[0]) ? int.Parse(Y) : table.GetValueOrDefault(Y);

        return a + b;
    }
}

/**
 * Your Spreadsheet object will be instantiated and called as such:
 * Spreadsheet obj = new Spreadsheet(rows);
 * obj.SetCell(cell,value);
 * obj.ResetCell(cell);
 * int param_3 = obj.GetValue(formula);
 */
 // @lc code=end

