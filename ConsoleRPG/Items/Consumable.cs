public class Consumable: Item
{
    public int? InventoryId { get; set; }
    public int? Amount { get; set; }
    public int MaxCapacity { get; set; }
}