namespace LeetCodeNet.G0001_0100.S0051_n_queens
{

    // #Hard #Top_100_Liked_Questions #Array #Backtracking #Big_O_Time_O(N!)_Space_O(N)
    // #2024_01_04_Time_106_ms_(96.34%)_Space_54.6_MB_(5.79%)

    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            return this.Backtrack(n, 0, (x, y) => false).ToList();
        }

        private IEnumerable<IList<string>> Backtrack(int boardSize, int y, Func<int, int, bool> check)
        {
            for (int x = 0; x < boardSize; x++)
            {
                if (check(x, y))
                {
                    continue;
                }

                string currentLine = $"{new string('.', x)}Q{new string('.', boardSize - x - 1)}";

                if (y == boardSize - 1)
                {
                    yield return new List<string> { currentLine };
                    continue;
                }

                var results = this.Backtrack(boardSize, y + 1, (xx, yy) =>
                    check(xx, yy) ||
                    (xx == x) ||
                    (yy == (y - x) + xx) ||
                    (yy == (x + y) - xx)
                );

                foreach (var result in results)
                {
                    result.Add(currentLine);
                    yield return result;
                }
            }
        }
    }
}
