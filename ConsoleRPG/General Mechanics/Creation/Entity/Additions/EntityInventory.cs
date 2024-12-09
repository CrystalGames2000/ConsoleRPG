public class EntityInventory
{
    Inventory Inventory { get; set; }

    public EntityInventory(Inventory inventory) {
        Inventory = inventory;
    }
}