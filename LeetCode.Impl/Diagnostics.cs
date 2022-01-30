using System.Diagnostics;
namespace LeetCode.Impl;

internal class Diagnostics
{
    public static void DumpGrid<T>(ref T?[,] grid)
    {
        for (int row = 0; row < grid.GetLength(0); row++)
        {
            Debug.Write("[ ");
            for (int col = 0; col < grid.GetLength(1); col++)
            {
                var val = (grid[row, col] == null) ? "___ " : $"{grid[row, col],-3} ";
                Debug.Write(val);
            }
            Debug.WriteLine("]");
        }
        Debug.WriteLine("-------------");
    }
}
