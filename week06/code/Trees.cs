public static class Trees
{
    /// <summary>
    /// Given a sorted list (sorted_list), create a balanced BST.
    /// </summary>
    public static BinarySearchTree CreateTreeFromSortedList(int[] sortedNumbers)
    {
        var bst = new BinarySearchTree();

        InsertMiddle(sortedNumbers, 0, sortedNumbers.Length - 1, bst);

        return bst;
    }

    /// <summary>
    /// Insert middle values recursively to create a balanced BST.
    /// </summary>
    private static void InsertMiddle(
        int[] sortedNumbers,
        int first,
        int last,
        BinarySearchTree bst)
    {
        // Problem 5

        if (first > last)
            return;

        int middle = (first + last) / 2;

        bst.Insert(sortedNumbers[middle]);

        InsertMiddle(sortedNumbers, first, middle - 1, bst);

        InsertMiddle(sortedNumbers, middle + 1, last, bst);
    }
}