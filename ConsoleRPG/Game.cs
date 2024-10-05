public class Game
{
    static bool skipIntro = true;
    static bool skipRegister = false;

    static string raceStatModifier = "";
    static string saveSlot = "";
    static string newGame = "";

    static Player? player;

    static string? firstName, lastName, playerRace, playerClass = "";
    static int strMod, dexMod, conMod, intMod, wisMod, chaMod, moveSpeed, cp, sp, gp, pp, health = 0;

    public static void Main(string[] args) {

        Console.Title = "CrystalGames' ConsoleRPG";
        if(!skipIntro) StartIntro();

        if(!skipRegister) RegisterCharacter();
        PlayerDataManager.DisplayPlayerStats(player);
        Console.Clear();

        ItemDataManager.LoadWeapons(ItemManager.weapons);
        ItemDataManager.DisplayWeapons(ItemManager.weapons);

        Console.Read();
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
        firstName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Please choose your character's last name: ");
        lastName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Plesae choose your character's race from the following list:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman");
        playerRace = Console.ReadLine();
        Console.Clear();
        switch (playerRace.ToUpper()) {
            case "DWARF":
                conMod += 2;
                wisMod += 2;
                chaMod -= 2;
                moveSpeed = 20;
                break;
            case "ELF":
                dexMod = 2;
                intMod = 2;
                conMod = -2;
                moveSpeed = 30;
                break;
            case "GNOME":
                strMod -= 2;
                conMod += 2;
                chaMod += 2;
                moveSpeed = 20;
                break;
            case "HALFELF":
                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                raceStatModifier = Console.ReadLine();
                switch (raceStatModifier.ToUpper()) {
                    case "STR":
                        strMod += 2;
                        break;
                    case "DEX":
                        dexMod += 2;
                        break;
                    case "CON":
                        conMod += 2;
                        break;
                    case "INT":
                        intMod += 2;
                        break;
                    case "WIS":
                        wisMod += 2;
                        break;
                    case "CHA":
                        chaMod += 2;
                        break;
                }
                moveSpeed = 30;

                break;
            case "HALFORC":
                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                raceStatModifier = Console.ReadLine();
                switch (raceStatModifier.ToUpper()) {
                    case "STR":
                        strMod += 2;
                        break;
                    case "DEX":
                        dexMod += 2;
                        break;
                    case "CON":
                        conMod += 2;
                        break;
                    case "INT":
                        intMod += 2;
                        break;
                    case "WIS":
                        wisMod += 2;
                        break;
                    case "CHA":
                        chaMod += 2;
                        break;
                }
                moveSpeed = 30;

                break;
            case "HALFLING":
                strMod -= 2;
                dexMod += 2;
                chaMod += 2;
                moveSpeed = 20;
                break;
            case "HUMAN":
                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                raceStatModifier = Console.ReadLine();
                switch (raceStatModifier.ToUpper()) {
                    case "STR":
                        strMod += 2;
                        break;
                    case "DEX":
                        dexMod += 2;
                        break;
                    case "CON":
                        conMod += 2;
                        break;
                    case "INT":
                        intMod += 2;
                        break;
                    case "WIS":
                        wisMod += 2;
                        break;
                    case "CHA":
                        chaMod += 2;
                        break;
                }
                moveSpeed = 30;

                break;
        }

        Console.Clear();
        Console.WriteLine("Please chooe your character's class from the following list:\nBarbarian\nBard\nCleric\nDruid\nFighter\nMonk\nPaladin\nRanger\nRogue\nSorcerer\nWizard");
        playerClass = Console.ReadLine();
        switch (playerClass.ToUpper()) {
            case "BARBARIAN":
                gp += Dice.Roll(6, 3) * 10;
                health = 1 + Dice.Roll(12, 1, conMod);
                break;
            case "BARD":
                gp += Dice.Roll(6, 3) * 10;
                health = 1 + Dice.Roll(8, 1, conMod);
                break;
            case "CLERIC":
                gp += Dice.Roll(6, 4) * 10;
                health = 1 + Dice.Roll(8, 1, conMod);
                break;
            case "DRUID":
                gp += Dice.Roll(6, 2) * 10;
                health = 1 + Dice.Roll(8, 1, conMod)    ;
                break;
            case "FIGHTER":
                gp += Dice.Roll(6, 5) * 10;
                health = 1 + Dice.Roll(10, 1, conMod);
                break;
            case "MONK":
                gp += Dice.Roll(6, 1) * 10;
                health = 1 + Dice.Roll(8, 1, conMod);
                break;
            case "PALADIN":
                gp += Dice.Roll(6, 5) * 10;
                health = 1 + Dice.Roll(10, 1, conMod);
                break;
            case "RANGER":
                gp += Dice.Roll(6, 5) * 10;
                health = 1 + Dice.Roll(10, 1, conMod);
                break;
            case "ROGUE":
                gp += Dice.Roll(6, 4) * 10;
                health = 1 + Dice.Roll(8, 1, conMod);
                break;
            case "SORCERER":
                gp += Dice.Roll(6, 2) * 10;
                health = 1 + Dice.Roll(6, 1, conMod);
                break;
            case "WIZARD":
                gp += Dice.Roll(6, 2) * 10;
                health = 1 + Dice.Roll(6, 1, conMod);
                break;
        }

        player = new Player(firstName, lastName, playerRace, playerClass, 0, 0, cp, sp, gp, pp, moveSpeed, health, strMod, dexMod, conMod, intMod, wisMod, chaMod, 0, 0, 0, 0, 0, 0);

        PlayerDataManager.RegisterPlayer(player);

        Console.Clear();
    }
}
