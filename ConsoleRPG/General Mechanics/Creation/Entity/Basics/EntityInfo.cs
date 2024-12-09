public class EntityInfo
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }

    public EntityInfo(string name, int level, int health, int maxHealth) {
        Name = name;
        Level = level;
        Health = health;
        MaxHealth = maxHealth;
    }
}