public class Player
{
    public PlayerInfo PlayerInfo { get; set; }
    public PlayerWallet PlayerWallet { get; set; }
    public PlayerStats Stats {get; set;}
    public PlayerStatMods StatsMods {get; set;}
    public List<Item> Inventory    {get; set;}

    public Player(PlayerInfo playerInfo, PlayerWallet playerWallet, PlayerStats stats, PlayerStatMods statsMods, List<Item> inventory) {
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
public class PlayerWallet
{
    public int CP { get; set; }
    public int SP { get; set; }
    public int GP { get; set; }
    public int PP { get; set; }

    public PlayerWallet(int cp, int sp, int gp, int pp) {
        CP = cp;
        SP = sp;
        GP = gp;
        PP = pp;
    }
}
public class PlayerStats
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public PlayerStats(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }
}
public class PlayerStatMods
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public PlayerStatMods(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }
}