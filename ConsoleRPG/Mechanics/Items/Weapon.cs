public class Weapon: Item
{
    public int? InventoryId { get; set; }
    public int? Amount { get; set; }
    public int MaxCapacity { get; set; }
    public string? Name { get; set; }
    public int? Cost { get; set; }
    public string? DmgS {  get; set; }
    public string? DmgM { get; set; }
    public string? Critical {  get; set; }
    public double? Range { get; set; }
    public double? Weight { get; set; }
    public string[]? Type { get; set; }
    public string[]? Special {  get; set; }

    public Weapon(int? inventoryId, int? amount, int maxCapacity, string? name, int? cost, string? dmgS, string? dmgM, string? critical, double? range, double? weight, string[]? type, string[]? special) {
        InventoryId = inventoryId;
        Amount = amount;
        MaxCapacity = maxCapacity;
        Name = name;
        Cost = cost;
        DmgS = dmgS;
        DmgM = dmgM;
        Critical = critical;
        Range = range;
        Weight = weight;
        Type = type;
        Special = special;
    }
}