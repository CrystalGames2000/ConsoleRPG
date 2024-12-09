public class Player
{
    public PlayerInfo? PlayerInfo { get; set; }
    public EntityWallet? PlayerWallet { get; set; }
    public EntityStats? Attributes {get; set;}
    public EntityStatModifiers? AttributeMods {get; set;}
    public Inventory? Inventory    {get; set;}

    public Player(PlayerInfo? playerInfo, EntityWallet? playerWallet, EntityStats? attributes, EntityStatModifiers? attributeMods, Inventory inventory) {
        PlayerInfo = playerInfo;
        PlayerWallet = playerWallet;
        Attributes = attributes;
        AttributeMods = attributeMods;
        Inventory = inventory;
    }
}