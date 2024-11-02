public class Player
{
    public PlayerInfo PlayerInfo { get; set; }
    public EntityWallet PlayerWallet { get; set; }
    public EntityStats Stats {get; set;}
    public EntityStatModifiers StatMods {get; set;}
    public List<Item> Inventory    {get; set;}

    public Player(PlayerInfo playerInfo, EntityWallet playerWallet, EntityStats stats, EntityStatModifiers statMods, List<Item> inventory) {
        PlayerInfo = playerInfo;
        PlayerWallet = playerWallet;
        Stats = stats;
        StatMods = statMods;
        Inventory = inventory;
    }
}