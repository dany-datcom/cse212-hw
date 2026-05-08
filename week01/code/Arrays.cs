public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array with the size provided by length.
        // This array will store all multiples of the number.

        // Step 2: Use a loop to go through each position in the array.

        // Step 3: For each position, calculate the multiple.
        // Since array indexes start at 0, use (i + 1) to get:
        // number * 1, number * 2, number * 3, etc.

        // Step 4: Store each multiple in the array.

        // Step 5: Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Find the position where the list should be split.
        // Example:
        // If the list has 9 items and amount is 3,
        // the split index will be 9 - 3 = 6.

        // Step 2: Copy the items from the split index to the end of the list.
        // These are the items that will move to the front.

        // Step 3: Remove those items from the original list.

        // Step 4: Insert the copied items at the beginning of the list.

        int splitIndex = data.Count - amount;

        List<int> movedItems = data.GetRange(splitIndex, amount);

        data.RemoveRange(splitIndex, amount);

        data.InsertRange(0, movedItems);
    }
}