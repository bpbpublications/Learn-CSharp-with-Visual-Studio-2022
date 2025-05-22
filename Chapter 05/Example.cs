public class Purchase
{
    public int PurchaseId { get; set; }
    public string ItemName { get; set; }
    public decimal Cost { get; set; }
    public int ItemCount { get; set; }

    public Purchase(int purchaseId, string itemName, decimal cost, int itemCount)
    {
        PurchaseId = purchaseId;
        ItemName = itemName;
        Cost = cost;
        ItemCount = itemCount;
    }

    public decimal NetCost()
    {
        return Cost * ItemCount;
    }
}

public class Buyer
{
    public string BuyerName { get; set; }
    public string BuyerEmail { get; set; }
    public List<Purchase> Purchases { get; set; }

    public Buyer(string buyerName, string buyerEmail)
    {
        BuyerName = buyerName;
        BuyerEmail = buyerEmail;
        Purchases = new List<Purchase>();
    }

    public void OrderPlacement(Purchase purchase)
    {
        Purchases.Add(purchase);
        Console.WriteLine($"Order placed for {purchase.ItemName} by {BuyerName}");
    }

    public void ShowBuyerInformation()
    {
        Console.WriteLine($"Buyer Name: {BuyerName}");
        Console.WriteLine($"Buyer Email: {BuyerEmail}");
        Console.WriteLine("Purchases:");
        foreach (var purchase in Purchases)
        {
            Console.WriteLine($"  Purchase Id: {purchase.PurchaseId}");
            Console.WriteLine($"  Product: {purchase.ItemName}");
            Console.WriteLine($"  Cost: ${purchase.Cost}");
            Console.WriteLine($"  ItemCount: {purchase.ItemCount}");
            Console.WriteLine($"  Total: ${purchase.NetCost()}");
            Console.WriteLine();
        }
    }
}

public class Exanmple
{
    public static void Main(string[] args)
    {
        Buyer buyer1 = new Buyer("Cynthia", "Cynthia@example.com");
        Purchase order1 = new Purchase(1, "Tablet", 539.99m, 2);
        Purchase order2 = new Purchase(2, "Earbuds", 299.99m, 3);

        buyer1.OrderPlacement(order1);
        buyer1.OrderPlacement(order2);

        Console.WriteLine();
        buyer1.ShowBuyerInformation();
    }
}
