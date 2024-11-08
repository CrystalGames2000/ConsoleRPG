public class PlayerInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Race Race { get; set; }
    public Class Class { get; set; }
    public int Level { get; set; }
    public int XP { get; set; }
    public int MoveSpeed { get; set; }
    public int Health { get; set; }
    public int MaxHP { get; set; }

    public PlayerInfo(string firstName, string lastName, Race race, Class pClass, int level, int xP, int moveSpeed, int health, int maxHP) {
        FirstName = firstName;
        LastName = lastName;
        Race = race;
        Class = pClass;
        Level = level;
        XP = xP;
        MoveSpeed = moveSpeed;
        Health = health;
        MaxHP = maxHP;
    }
}