public class Player
{
    public PlayerInfo? PlayerInfo { get; set; }
    public EntityWallet? PlayerWallet { get; set; }
    public EntityStats? Attributes {get; set;}
    public EntityStatModifiers? StatMods {get; set;}
    public List<Item>? Inventory    {get; set;}

    public Player(PlayerInfo? playerInfo, EntityWallet? playerWallet, EntityStats? attributes, EntityStatModifiers? statMods, List<Item>? inventory) {
        PlayerInfo = playerInfo;
        PlayerWallet = playerWallet;
        Attributes = attributes;
        StatMods = statMods;
        Inventory = inventory;
    }
}