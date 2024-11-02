public class InventoryManager
{
    int lastItemId = 0;
    public List<Item> inventory;
    public void AddItem(Item item) {
        inventory.Append(item);
        item.InventoryId = lastItemId;
        lastItemId++;
    }

    public void RemoveItem(int itemId) {
        inventory[itemId] = null;
    }
}