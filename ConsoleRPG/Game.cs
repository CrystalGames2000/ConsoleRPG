public static class Game
{
    static bool introSkip = true;
    static bool skipRegister = false;

    public static string raceStatModfier = "";
    public static int saveSlot;
    public static string newGame = "";

    public static PlayerData player = new PlayerData();
    public static void Main(string[] args) {

        Console.Title = "CrystalGames' ConsoleRPG";

        #region Intro
        if (!introSkip) {
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

        #endregion

        Console.WriteLine("Would you like to start a new game? [y/n]");
        newGame = Console.ReadLine();
        switch (newGame.ToUpper()) {
            case "Y":
                //Asks for save file
                Console.WriteLine("Please Select a save slot (1-6): ");
                saveSlot = 

                RegisterPlayer();
                break;
            case "N":
                DataManager.LoginPlayer(player);
                break;
        }
    }

    static void RegisterPlayer()
    {

        //Recieves player's first name
        Console.WriteLine("Please choose your character's first name: ");
        player.PlayerFirstName = Console.ReadLine();
        Console.Clear();

        //Recieves player's last name
        Console.WriteLine("Please choose your character's last name: ");
        player.PlayerLastName = Console.ReadLine();
        Console.Clear();

        //Recieves the player's race
        Console.WriteLine("Please pick a race:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman\n");
        player.PlayerRace = Console.ReadLine();
        Console.Clear();
        switch (player.PlayerRace.ToUpper())
            {
                case ("DWARF"):
                    player.PlayerConMod += 2;
                    player.PlayerWisMod += 2;
                    player.PlayerChaMod -= 2;
                    break;
                case ("ELF"):
                    player.PlayerDexMod += 2;
                    player.PlayerConMod -= 2;
                    player.PlayerIntMod += 2;
                    break;
                case ("GNOME"):
                    player.PlayerStrMod -= 2;
                    player.PlayerConMod += 2;
                    player.PlayerChaMod += 2;
                    break;
                case ("HALFELF"):
                    Console.WriteLine("Please pick a stat modifier:\nstr(ength)\ndex(terity)\ncon(stitution)\nint(elligence)\nwis(dom)\ncha(risma)");
                    raceStatModfier = Console.ReadLine();
                    raceStatModfier.ToUpper();
                    switch (raceStatModfier)
                    {
                        case ("str"):
                            player.PlayerStrMod += 2;
                            break;
                        case ("dex"):
                            player.PlayerDexMod += 2;
                            break;
                        case ("con"):
                            player.PlayerConMod += 2;
                            break;
                        case ("int"):
                            player.PlayerIntMod += 2;
                            break;
                        case ("wis"):
                            player.PlayerWisMod += 2;
                            break;
                        case ("cha"):
                            player.PlayerChaMod += 2;
                            break;
                        default:
                            Console.WriteLine("Invalid stat, please re-type the stat you would like to increase:\nstr(ength)\ndex(terity)\ncon(stitution)\nint(elligence)\nwis(dom)\ncha(risma)");
                            raceStatModfier = Console.ReadLine();
                            raceStatModfier.ToUpper();
                            break;
                    }
                    Console.Clear();
                    break;
                case ("HALFORC"):
                    Console.WriteLine("Please pick a stat modifier:\nstr(ength)\ndex(terity)\ncon(stitution)\nint(elligence)\nwis(dom)\ncha(risma)");
                    raceStatModfier = Console.ReadLine();
                    raceStatModfier.ToUpper();
                    switch (raceStatModfier)
                    {
                        case ("str"):
                            player.PlayerStrMod += 2;
                            break;
                        case ("dex"):
                            player.PlayerDexMod += 2;
                            break;
                        case ("con"):
                            player.PlayerConMod += 2;
                            break;
                        case ("int"):
                            player.PlayerIntMod += 2;
                            break;
                        case ("wis"):
                            player.PlayerWisMod += 2;
                            break;
                        case ("cha"):
                            player.PlayerChaMod += 2;
                            break;
                        default:
                            Console.WriteLine("Invalid stat, please re-type the stat you would like to increase:\nstr(ength)\ndex(terity)\ncon(stitution)\nint(elligence)\nwis(dom)\ncha(risma)");
                            raceStatModfier = Console.ReadLine();
                            raceStatModfier.ToUpper();
                            break;
                    }
                    Console.Clear();
                    break;
                case ("HALFLING"):
                    player.PlayerStrMod -= 2;
                    player.PlayerDexMod += 2;
                    player.PlayerChaMod += 2;
                    break;
                case ("HUMAN"):
                    Console.WriteLine("Please pick a stat modifier:\nstr(ength)\ndex(terity)\ncon(stitution)\nint(elligence)\nwis(dom)\ncha(risma)");
                    raceStatModfier = Console.ReadLine();
                    raceStatModfier.ToUpper();
                    switch (raceStatModfier)
                    {
                        case ("str"):
                            player.PlayerStrMod += 2;
                            break;
                        case ("dex"):
                            player.PlayerDexMod += 2;
                            break;
                        case ("con"):
                            player.PlayerConMod += 2;
                            break;
                        case ("int"):
                            player.PlayerIntMod += 2;
                            break;
                        case ("wis"):
                            player.PlayerWisMod += 2;
                            break;
                        case ("cha"):
                            player.PlayerChaMod += 2;
                            break;
                        default:
                            Console.WriteLine("Invalid stat, please re-type the stat you would like to increase:\nstr(ength)\ndex(terity)\ncon(stitution)\nint(elligence)\nwis(dom)\ncha(risma)");
                            raceStatModfier = Console.ReadLine();
                            raceStatModfier.ToUpper();
                            break;
                    }
                    Console.Clear();
                    break;
            }
        Console.Clear();

        //Recieves the player's class
        Console.WriteLine("Please pick a class:\nBarbarian\nBard\nCleric\nDruid\nFighter\nMonk\nPaladin\nRanger\nRogue\nSorcerer\nWizard\n");
        player.PlayerClass = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Generating Ability Scores...");
        Thread.Sleep(1250);
        int abilityScores = GenerateAbilityScores();

        while(abilityScores > 0) {
                Console.WriteLine($"You now have {abilityScores} Points");
                Console.WriteLine("Please type the amount of ability scores you would like\nto increase, separated by a comma (Please avoid\nusing spaces), using this order:\nStrength\nDexterity\nConstitution\nIntelligence\nWisdom\nCharisma\n");
                string abiliyScoreMod = Console.ReadLine();
                string[] scoreModArrStr = abiliyScoreMod.Split(",");
                int[] scoreModArr = Array.ConvertAll(scoreModArrStr, int.Parse);
                player.PlayerStrMod += scoreModArr[0];
                abilityScores -= scoreModArr[0];
                player.PlayerDexMod += scoreModArr[1];
                abilityScores -= scoreModArr[1];
                player.PlayerConMod += scoreModArr[2];
                abilityScores -= scoreModArr[2];
                player.PlayerIntMod += scoreModArr[3];
                abilityScores -= scoreModArr[3];
                player.PlayerWisMod += scoreModArr[4];
                abilityScores -= scoreModArr[4];
                player.PlayerChaMod += scoreModArr[5];
                abilityScores -= scoreModArr[5];
                Console.Clear();
            }


        //Handles Health Management
        switch (player.PlayerClass.ToUpper()) {
                case ("BARBARIAN"):
                    player.PlayerHealth = 1 + Dice.Roll(12, 1, player.PlayerConMod);
                    break;
                case ("BARD"):
                    player.PlayerHealth = 1 + Dice.Roll(8, 1, player.PlayerConMod);
                    break;
                case ("CLERIC"):
                    player.PlayerHealth = 1 + Dice.Roll(8, 1, player.PlayerConMod);
                    break;
                case ("DRUID"):
                    player.PlayerHealth = 1 + Dice.Roll(8, 1, player.PlayerConMod);
                    break;
                case ("FIGHTER"):
                    player.PlayerHealth = 1 + Dice.Roll(10, 1, player.PlayerConMod);
                    break;
                case ("MONK"):
                    player.PlayerHealth = 1 + Dice.Roll(8, 1, player.PlayerConMod);
                    break;
                case ("PALADIN"):
                    player.PlayerHealth = 1 + Dice.Roll(10, 1, player.PlayerConMod);
                    break;
                case ("RANGER"):
                    player.PlayerHealth = 1 + Dice.Roll(10, 1, player.PlayerConMod);
                    break;
                case ("ROGUE"):
                    player.PlayerHealth = 1 + Dice.Roll(8, 1, player.PlayerConMod);
                    break;
                case ("SORCERER"):
                    player.PlayerHealth = 1 + Dice.Roll(6, 1, player.PlayerConMod);
                    break;
                case ("WIZARD"):
                    player.PlayerHealth = 1 + Dice.Roll(6, 1, player.PlayerConMod);
                    break;
            }

        Console.Clear();
        Console.Write("Saving Data");
        Thread.Sleep(Dice.Roll(500, 2, 750));
        Console.Write(".");
        Thread.Sleep(Dice.Roll(500, 2, 750));
        Console.Write(".");
        Thread.Sleep(Dice.Roll(500, 2, 750));
        Console.Write(".");
        Thread.Sleep(Dice.Roll(500, 2, 750));
        Console.Clear();

        DataManager.RegisterNewPlayer(player, saveSlot);
        Console.WriteLine("Player successfully created");
    }

    static int GenerateAbilityScores()
    {
        int[] rolls = new int[4];
        rolls[0] = Dice.Roll(6);
        rolls[1] = Dice.Roll(6);
        rolls[2] = Dice.Roll(6);
        rolls[3] = Dice.Roll(6);
        Array.Sort(rolls);

        return rolls[0] + rolls[1] + rolls[2];
    }
}
