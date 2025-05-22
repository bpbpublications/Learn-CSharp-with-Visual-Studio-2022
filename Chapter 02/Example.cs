class Example
{
    static void Main()
    {
        // Variable declaration
        int numberOfItems, costPerItem, totalCost;
        float averageCost;

        // Initialization
        numberOfItems = 10; // Let us say we bought 10 items
        costPerItem = 5;    // Each item costs $5

        // Using arithmetic operators
        totalCost = numberOfItems * costPerItem; // Total cost is number of items times cost per item
        averageCost = (float)totalCost / numberOfItems; // Average cost is total cost divided by number of items

        // Displaying results
        Console.WriteLine("The total cost for " + numberOfItems + " items is $" + totalCost);
        Console.WriteLine("The average cost per item is $" + averageCost);

        // End of program
    }
}
