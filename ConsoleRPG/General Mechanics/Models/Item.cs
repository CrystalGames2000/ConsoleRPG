public class Item
{
    public int? InventoryId { get; set; }
    public int? Amount { get; set; }
    public int MaxCapacity { get; set; }

    public Item(int? inventoryId, int? amount, int maxCapacity) {
        InventoryId = inventoryId;
        Amount = amount;
        MaxCapacity = maxCapacity;
    }
}