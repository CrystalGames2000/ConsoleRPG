public class Inventory
{
    int lastItemId = 0;
    Item[]? inventory;

    void AddItem(Item item) {
        inventory.Append(item);
        item.InventoryId = lastItemId;
        lastItemId++;
    }

    public void RemoveItem(int itemId) {
        inventory[itemId] = null;
    }

    public Item GetItemById(int itemId) {
        return inventory[itemId];
    }
}