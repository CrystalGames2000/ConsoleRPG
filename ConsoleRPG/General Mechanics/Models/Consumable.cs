public class Consumable: Item
{
    public string Name { get; set; }
    public Consumable(int? inventoryId, int? amount, int maxCapacity,string name): base(inventoryId, amount, maxCapacity) {
        Name = name;
    }
}