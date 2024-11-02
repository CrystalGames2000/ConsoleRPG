public class PlayerDataManager
{
    static string raceStatModifier = "";

    static PlayerInfo playerInfo;
    static EntityWallet playerWallet;
    static EntityStats playerStats;
    static EntityStatModifiers playerStatMods;
    static List<Item> inventory;

    public static Player? player;

    public static Player RegisterCharacter() {

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
                playerInfo.Health = 1 + Dice.Roll(8, 1, playerStatMods.Constitution);
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
            default:
                Commands.CheckForCommand();
                break;
        }

        Console.Clear();

        return new Player(playerInfo, playerWallet, playerStats, playerStatMods, inventory);


    }

    public static void DisplayPlayerStats(Player player) {
        Console.WriteLine("==============================");
        Console.WriteLine("|First Name                : " + player.PlayerInfo.FirstName);
        Console.WriteLine("|Last Name                 : " + player.PlayerInfo.LastName);
        Console.WriteLine("|Race                      : " + player.PlayerInfo.Race);
        Console.WriteLine("|Class                     : " + player.PlayerInfo.Class);
        Console.WriteLine("|Level                     : " + player.PlayerInfo.Level);
        Console.WriteLine("|Experience                : " + player.PlayerInfo.XP);
        Console.WriteLine("|Copper                    : " + player.PlayerWallet.CP);
        Console.WriteLine("|Silver                    : " + player.PlayerWallet.SP);
        Console.WriteLine("|Gold                      : " + player.PlayerWallet.GP);
        Console.WriteLine("|Platinum                  : " + player.PlayerWallet.PP);
        Console.WriteLine("|Move Speed                : " + player.PlayerInfo.MoveSpeed);
        Console.WriteLine("|Health                    : " + player.PlayerInfo.Health);
        Console.WriteLine("|Strength Mod              : " + player.StatMods.Strength);
        Console.WriteLine("|Dexterity Mod             : " + player.StatMods.Dexterity);
        Console.WriteLine("|Constitution Mod          : " + player.StatMods.Constitution);
        Console.WriteLine("|Intelligence Mod          : " + player.StatMods.Intelligence);
        Console.WriteLine("|Wisdom Mod                : " + player.StatMods.Wisdom);
        Console.WriteLine("|Charisma Mod              : " + player.StatMods.Charisma);
        Console.WriteLine("|Strength                  : " + player.Stats.Strength);
        Console.WriteLine("|Dexterity                 : " + player.Stats.Dexterity);
        Console.WriteLine("|Constitution              : " + player.Stats.Constitution);
        Console.WriteLine("|Intelligence              : " + player.Stats.Intelligence);
        Console.WriteLine("|Wisdom                    : " + player.Stats.Wisdom);
        Console.WriteLine("|Charisma                  : " + player.Stats.Charisma);
        Console.WriteLine("==============================");

    }
}