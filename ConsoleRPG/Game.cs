public class Game
{
    static bool skipIntro = true;
    static bool skipRegister = false;

    static string raceStatModifier = "";
    static string saveSlot = "";
    static string newGame = "";

    static Player? player;

    static PlayerInfo? playerInfo;
    static PlayerWallet? playerWallet;
    static PlayerStats? playerStats;
    static PlayerStatMods? playerStatMods;
    static List<Item>? inventory;
    


    public static void Main(string[] args) {
        Startup();

        Console.Read();
    }

    static void Startup() {
        Console.Title = "CrystalGames' ConsoleRPG";
        if (!skipIntro) StartIntro();

        if (!skipRegister) RegisterCharacter();

    }

    static void StartIntro() {
        Console.WriteLine("Getting Things Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Processing Data...");
        Thread.Sleep(1500);
        Console.WriteLine("Finishing Things Up...");
        Thread.Sleep(1750);
        Console.Clear();
        #region Logo
        Console.WriteLine("=======================================================================");
        Thread.Sleep(350);
        Console.WriteLine("\r _____                _        _ _____                           \r");
        Thread.Sleep(350);
        Console.WriteLine("/  __ \\              | |      | |  __ \\                          \r");
        Thread.Sleep(350);
        Console.WriteLine("| /  \\/_ __ _   _ ___| |_ __ _| | |  \\/ __ _ _ __ ___   ___  ___ \r");
        Thread.Sleep(350);
        Console.WriteLine("| |   | '__| | | / __| __/ _` | | | __ / _` | '_ ` _ \\ / _ \\/ __|\r");
        Thread.Sleep(350);
        Console.WriteLine("| \\__/\\ |  | |_| \\__ \\ || (_| | | |_\\ \\ (_| | | | | | |  __/\\__ \\\r");
        Thread.Sleep(350);
        Console.WriteLine(" \\____/_|   \\__, |___/\\__\\__,_|_|\\____/\\__,_|_| |_| |_|\\___||___/\r");
        Thread.Sleep(350);
        Console.WriteLine("             __/ |                                               \r");
        Thread.Sleep(350);
        Console.WriteLine("            |___/                                                \r");
        Thread.Sleep(350);
        Console.WriteLine(" _____                       _     ____________ _____            \r");
        Thread.Sleep(350);
        Console.WriteLine("/  __ \\                     | |    | ___ \\ ___ \\  __ \\           \r");
        Thread.Sleep(350);
        Console.WriteLine("| /  \\/ ___  _ __  ___  ___ | | ___| |_/ / |_/ / |  \\/           \r");
        Thread.Sleep(350);
        Console.WriteLine("| |    / _ \\| '_ \\/ __|/ _ \\| |/ _ \\    /|  __/| | __            \r");
        Thread.Sleep(350);
        Console.WriteLine("| \\__/\\ (_) | | | \\__ \\ (_) | |  __/ |\\ \\| |   | |_\\ \\           \r");
        Thread.Sleep(350);
        Console.WriteLine(" \\____/\\___/|_| |_|___/\\___/|_|\\___\\_| \\_\\_|    \\____/           \r"); Thread.Sleep(350);
        Console.WriteLine("=======================================================================");
        Thread.Sleep(250);
        Console.WriteLine("Press anything to continue");
        Console.ReadKey();
        Console.Clear();
        #endregion
    }

    static void RegisterCharacter() {

        Console.Clear();
        Console.WriteLine("Please choose your character's first name: ");
        playerInfo.FirstName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Please choose your character's last name: ");
        playerInfo.LastName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Plesae choose your character's race from the following list:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman");
        playerInfo.Race = Console.ReadLine();
        Console.Clear();
        switch (playerInfo.Race.ToUpper()) {
            case "DWARF":
                playerStatMods.Constitution += 2;
                playerStatMods.Wisdom += 2;
                playerStatMods.Charisma -= 2;
                playerInfo.MoveSpeed = 20;
                break;
            case "ELF":
                playerStatMods.Dexterity = 2;
                playerStatMods.Intelligence = 2;
                playerStatMods.Constitution = -2;
                playerInfo.MoveSpeed = 30;
                break;
            case "GNOME":
                playerStatMods.Strength -= 2;
                playerStatMods.Constitution += 2;
                playerStatMods.Charisma += 2;
                playerInfo.MoveSpeed = 20;
                break;
            case "HALFLING":
                playerStatMods.Strength -= 2;
                playerStatMods.Dexterity += 2;
                playerStatMods.Charisma += 2;
                playerInfo.MoveSpeed = 20;
                break;
            case "HALFELF":
            case "HALFORC":
            case "HUMAN":
                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                raceStatModifier = Console.ReadLine();
                switch (raceStatModifier.ToUpper()) {
                    case "STR":
                        playerStatMods.Strength += 2;
                        break;
                    case "DEX":
                        playerStatMods.Dexterity += 2;
                        break;
                    case "CON":
                        playerStatMods.Constitution += 2;
                        break;
                    case "INT":
                        playerStatMods.Intelligence += 2;
                        break;
                    case "WIS":
                        playerStatMods.Wisdom += 2;
                        break;
                    case "CHA":
                        playerStatMods.Charisma += 2;
                        break;
                }
                playerInfo.MoveSpeed = 30;

                break;
        }

        Console.Clear();
        Console.WriteLine("Please chooe your character's class from the following list:\nBarbarian\nBard\nCleric\nDruid\nFighter\nMonk\nPaladin\nRanger\nRogue\nSorcerer\nWizard");
        playerInfo.Class = Console.ReadLine();
        switch (playerInfo.Class.ToUpper()) {
            case "BARBARIAN":
                playerWallet.GP += Dice.Roll(6, 3) * 10;
                playerInfo.Health = 1 + Dice.Roll(12, 1, playerStatMods.Constitution);
                break;
            case "BARD":
                playerWallet.GP += Dice.Roll(6, 3) * 10;
                playerInfo.Health = 1 + Dice.Roll(8, 1, playerStatMods.Constitution);
                break;
            case "CLERIC":
                playerWallet.GP += Dice.Roll(6, 4) * 10;
                playerInfo.Health = 1 + Dice.Roll(8, 1, playerStatMods.Constitution);
                break;
            case "DRUID":
                playerWallet.GP += Dice.Roll(6, 2) * 10;
                playerInfo.Health = 1 + Dice.Roll(8, 1, playerStatMods.Constitution)    ;
                break;
            case "FIGHTER":
                playerWallet.GP += Dice.Roll(6, 5) * 10;
                playerInfo.Health = 1 + Dice.Roll(10, 1, playerStatMods.Constitution);
                break;
            case "MONK":
                playerWallet.GP += Dice.Roll(6, 1) * 10;
                playerInfo.Health = 1 + Dice.Roll(8, 1, playerStatMods.Constitution);
                break;
            case "PALADIN":
                playerWallet.GP += Dice.Roll(6, 5) * 10;
                playerInfo.Health = 1 + Dice.Roll(10, 1, playerStatMods.Constitution);
                break;
            case "RANGER":
                playerWallet.GP += Dice.Roll(6, 5) * 10;
                playerInfo.Health = 1 + Dice.Roll(10, 1, playerStatMods.Constitution);
                break;
            case "ROGUE":
                playerWallet.GP += Dice.Roll(6, 4) * 10;
                playerInfo.Health = 1 + Dice.Roll(8, 1, playerStatMods.Constitution);
                break;
            case "SORCERER":
                playerWallet.GP += Dice.Roll(6, 2) * 10;
                playerInfo.Health = 1 + Dice.Roll(6, 1, playerStatMods.Constitution);
                break;
            case "WIZARD":
                playerWallet.GP += Dice.Roll(6, 2) * 10;
                playerInfo.Health = 1 + Dice.Roll(6, 1, playerStatMods.Constitution);
                break;
        }


        player = new Player(playerInfo, playerWallet, playerStats, playerStatMods, inventory);

        PlayerDataManager.RegisterPlayer(player);

        Console.Clear();
    }
}