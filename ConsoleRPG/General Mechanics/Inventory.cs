public class Inventory
{
    int lastItemId = 0;
    List<Item> inventory;

    public Inventory() {
        inventory = new List<Item>();
    }

    void AddItem(Item item) {
        inventory.Append(item);
        item.InventoryId = lastItemId;
        lastItemId++;
    }

    public void RemoveItem(int itemId) {
        inventory[itemId] = null;
    }
}