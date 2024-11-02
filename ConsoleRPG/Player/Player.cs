public class Player
{
    public PlayerInfo PlayerInfo { get; set; }
    public EntityWallet PlayerWallet { get; set; }
    public EntityStats Stats {get; set;}
    public EntityStatModifiers StatsMods {get; set;}
    public List<Item> Inventory    {get; set;}

    public Player(PlayerInfo playerInfo, EntityWallet playerWallet, EntityStats stats, EntityStatModifiers statsMods, List<Item> inventory) {
        PlayerInfo = playerInfo;
        PlayerWallet = playerWallet;
        Stats = stats;
        StatsMods = statsMods;
        Inventory = inventory;
    }
}
public class PlayerInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Race { get; set; }
    public string Class { get; set; }
    public int Level { get; set; }
    public int XP { get; set; }
    public int MoveSpeed { get; set; }
    public int Health { get; set; }

    public PlayerInfo(string firstName, string lastName, string race, string pClass, int level, int xP, int moveSpeed, int health) {
        FirstName = firstName;
        LastName = lastName;
        Race = race;
        Class = pClass;
        Level = level;
        XP = xP;
        MoveSpeed = moveSpeed;
        Health = health;
    }
}