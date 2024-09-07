public static class Game
{
    static bool skipIntro = false;
    static bool skipRegister = true;

    static string raceStatModifier = "";
    static string saveSlot = "";
    static string newGame = "";

    public static Player player = new Player();

    public static void Main(string[] args) {

        Console.Title = "CrystalGames' ConsoleRPG";
        if(!skipIntro) StartIntro();

        if(!skipRegister) RegisterCharacter();
    }

    public static void StartIntro() {
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

    public static void RegisterCharacter() {

        Console.Clear();
        Console.WriteLine("Please choose your character's first name: ");
        player.FirstName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Please choose your character's last name: ");
        player.LastName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Plesae choose your character's race from the following list:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman");
        player.Race = Console.ReadLine();
        switch (player.Race.ToUpper()) {
            case "DWARF":
                player.ConMod += 2;
                player.WisMod += 2;
                player.ChaMod -= 2;
                player.MoveSpeed = 20;
                break;
            case "ELF":
                player.DexMod += 2;
                player.IntMod += 2;
                player.ConMod -= 2;
                player.MoveSpeed = 30;
                break;
            case "GNOME":
                player.StrMod -= 2;
                player.ConMod += 2;
                player.ChaMod += 2;
                player.MoveSpeed = 20;
                break;
            case "HALFELF":
                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                raceStatModifier = Console.ReadLine();
                switch (raceStatModifier.ToUpper()) {
                    case "STR":
                        player.StrMod += 2;
                        break;
                    case "DEX":
                        player.DexMod += 2;
                        break;
                    case "CON":
                        player.ConMod += 2;
                        break;
                    case "INT":
                        player.IntMod += 2;
                        break;
                    case "WIS":
                        player.WisMod += 2;
                        break;
                    case "CHA":
                        player.ChaMod += 2;
                        break;
                }
                player.MoveSpeed += 30;

                break;
            case "HALFORC":
                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                raceStatModifier = Console.ReadLine();
                switch (raceStatModifier.ToUpper()) {
                    case "STR":
                        player.StrMod += 2;
                        break;
                    case "DEX":
                        player.DexMod += 2;
                        break;
                    case "CON":
                        player.ConMod += 2;
                        break;
                    case "INT":
                        player.IntMod += 2;
                        break;
                    case "WIS":
                        player.WisMod += 2;
                        break;
                    case "CHA":
                        player.ChaMod += 2;
                        break;
                }
                player.MoveSpeed += 30;

                break;
            case "HALFLING":
                player.StrMod -= 2;
                player.DexMod += 2;
                player.ChaMod += 2;
                player.MoveSpeed = 20;
                break;
            case "HUMAN":
                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                raceStatModifier = Console.ReadLine();
                switch (raceStatModifier.ToUpper()) {
                    case "STR":
                        player.StrMod += 2;
                        break;
                    case "DEX":
                        player.DexMod += 2;
                        break;
                    case "CON":
                        player.ConMod += 2;
                        break;
                    case "INT":
                        player.IntMod += 2;
                        break;
                    case "WIS":
                        player.WisMod += 2;
                        break;
                    case "CHA":
                        player.ChaMod += 2;
                        break;
                }
                player.MoveSpeed += 30;

                break;
        }

        Console.Clear();
        Console.WriteLine("Please chooe your character's class from the following list:\nBarbarian\nBard\nCleric\nDruid\nFighter\nMonk\nPaladin\nRanger\nRogue\nSorcerer\nWizard");
        player.Class = Console.ReadLine();
        switch (player.Class) {
            case "BARBARIAN":
                player.GP += Dice.Roll(6, 3) * 10;
                break;
            case "BARD":
                player.GP += Dice.Roll(6, 3) * 10;
                break;
            case "CLERIC":
                player.GP += Dice.Roll(6, 4) * 10;
                break;
            case "DRUID":
                player.GP += Dice.Roll(6, 2) * 10;
                break;
            case "FIGHTER":
                player.GP += Dice.Roll(6, 5) * 10;
                break;
            case "MONK":
                player.GP += Dice.Roll(6, 1) * 10;
                break;
            case "PALADIN":
                player.GP += Dice.Roll(6, 5) * 10;
                break;
            case "RANGER":
                player.GP += Dice.Roll(6, 5) * 10;
                break;
            case "ROGUE":
                player.GP += Dice.Roll(6, 4) * 10;
                break;
            case "SORCERER":
                player.GP += Dice.Roll(6, 2) * 10;
                break;
            case "WIZARD":
                player.GP += Dice.Roll(6, 2) * 10;
                break;
        }
    }
}
