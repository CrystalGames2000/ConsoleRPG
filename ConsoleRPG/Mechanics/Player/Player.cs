public class Player
{
    public string FirstName    {get; set;}
    public string LastName     {get; set;}
    public string Race         {get; set;}
    public string Class        {get; set;}
    public int    Level        {get; set;}
    public int    XP           {get; set;}
    public int    CP           {get; set;}
    public int    SP           {get; set;}
    public int    GP           {get; set;}
    public int    PP           {get; set;}
    public int    MoveSpeed    {get; set;}
    public int    Health       {get; set;}
    public int    StrMod       {get; set;}
    public int    DexMod       {get; set;}
    public int    ConMod       {get; set;}
    public int    IntMod       {get; set;}
    public int    WisMod       {get; set;}
    public int    ChaMod       {get; set;}
    public int    Strength     {get; set;}
    public int    Dexterity    {get; set;}
    public int    Constitution {get; set;}
    public int    Intelligence {get; set;}
    public int    Wisdom       {get; set;}
    public int    Charisma     {get; set;}

    public Player(string FirstName, string LastName, string Race, string Class, int Level, int XP, int CP, int SP, int GP, int PP, int MoveSpeed, int Health, int StrMod, int DexMod, int ConMod, int IntMod, int WisMod, int ChaMod, int Strength, int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma) {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Race = Race;
        this.Class = Class;
        this.Level = Level;
        this.XP = XP;
        this.CP = CP;
        this.SP = SP;
        this.GP = GP;
        this.PP = PP;
        this.MoveSpeed = MoveSpeed;
        this.Health = Health;
        this.StrMod = StrMod;
        this.DexMod = DexMod;
        this.ConMod = ConMod;
        this.IntMod = IntMod;
        this.WisMod = WisMod;
        this.ChaMod = ChaMod;
        this.Strength = Strength;
        this.Dexterity = Dexterity;
        this.Constitution = Constitution;
        this.Intelligence = Intelligence;
        this.Wisdom = Wisdom;
        this.Charisma = Charisma;
    }


}