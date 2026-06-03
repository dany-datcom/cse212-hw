using System.Collections;

public static class Recursion
{
    /// <summary>
    /// #############
    /// # Problem 1 #
    /// #############
    /// Using recursion, find the sum of 1^2 + 2^2 + 3^2 + ... + n^2
    /// and return it.
    /// </summary>
    public static int SumSquaresRecursive(int n)
    {
        if (n <= 0)
            return 0;

        return (n * n) + SumSquaresRecursive(n - 1);
    }

    /// <summary>
    /// #############
    /// # Problem 2 #
    /// #############
    /// Using recursion, insert permutations of length
    /// 'size' from a list of 'letters' into the results list.
    /// </summary>
    public static void PermutationsChoose(List<string> results, string letters, int size, string word = "")
    {
        if (word.Length == size)
        {
            results.Add(word);
            return;
        }

        foreach (char letter in letters)
        {
            if (!word.Contains(letter))
            {
                PermutationsChoose(results, letters, size, word + letter);
            }
        }
    }

    /// <summary>
    /// #############
    /// # Problem 3 #
    /// #############
    /// Count ways to climb stairs using memoization.
    /// </summary>
    public static decimal CountWaysToClimb(int s, Dictionary<int, decimal>? remember = null)
    {
        // Base Cases
        if (s == 0)
            return 0;
        if (s == 1)
            return 1;
        if (s == 2)
            return 2;
        if (s == 3)
            return 4;

        if (remember == null)
        {
            remember = new Dictionary<int, decimal>();
        }

        if (remember.ContainsKey(s))
        {
            return remember[s];
        }

        decimal ways =
            CountWaysToClimb(s - 1, remember) +
            CountWaysToClimb(s - 2, remember) +
            CountWaysToClimb(s - 3, remember);

        remember[s] = ways;

        return ways;
    }

    /// <summary>
    /// #############
    /// # Problem 4 #
    /// #############
    /// Insert all binary strings represented by a wildcard pattern.
    /// </summary>
    public static void WildcardBinary(string pattern, List<string> results)
    {
        int index = pattern.IndexOf('*');

        if (index == -1)
        {
            results.Add(pattern);
            return;
        }

        string zeroPattern =
            pattern[..index] + "0" + pattern[(index + 1)..];

        string onePattern =
            pattern[..index] + "1" + pattern[(index + 1)..];

        WildcardBinary(zeroPattern, results);
        WildcardBinary(onePattern, results);
    }

    /// <summary>
    /// #############
    /// # Problem 5 #
    /// #############
    /// Use recursion to insert all paths that start at (0,0) and end at the
    /// 'end' square into the results list.
    /// </summary>
    public static void SolveMaze(List<string> results, Maze maze, int x = 0, int y = 0, List<ValueTuple<int, int>>? currPath = null)
    {
        if (currPath == null)
        {
            currPath = new List<ValueTuple<int, int>>();
        }

        currPath.Add((x, y));

        if (maze.IsEnd(x, y))
        {
            results.Add(currPath.AsString());
            return;
        }

        // Right
        if (maze.IsValidMove(currPath, x + 1, y))
        {
            SolveMaze(
                results,
                maze,
                x + 1,
                y,
                new List<(int, int)>(currPath)
            );
        }

        // Left
        if (maze.IsValidMove(currPath, x - 1, y))
        {
            SolveMaze(
                results,
                maze,
                x - 1,
                y,
                new List<(int, int)>(currPath)
            );
        }

        // Down
        if (maze.IsValidMove(currPath, x, y + 1))
        {
            SolveMaze(
                results,
                maze,
                x,
                y + 1,
                new List<(int, int)>(currPath)
            );
        }

        // Up
        if (maze.IsValidMove(currPath, x, y - 1))
        {
            SolveMaze(
                results,
                maze,
                x,
                y - 1,
                new List<(int, int)>(currPath)
            );
        }
    }
}