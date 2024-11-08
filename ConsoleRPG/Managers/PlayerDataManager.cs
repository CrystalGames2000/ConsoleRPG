public class PlayerDataManager
{
    public static void RegisterCharacter(Player player) {

        string? inText = "";

        Console.Clear();
        Console.WriteLine("Please choose your character's first name: ");
        inText = Console.ReadLine();
        player.PlayerInfo.FirstName = inText;

        Console.Clear();
        Console.WriteLine("Please choose your character's last name: ");
        inText = Console.ReadLine();
        player.PlayerInfo.LastName = inText;

        Console.Clear();
        Console.WriteLine("Plesae choose your character's race from the following list:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman");
        inText = Console.ReadLine();
        Console.Clear();
        switch (inText.ToUpper()) {
            case "DWARF":
                player.PlayerInfo.Race = Race.Dwarf;
                player.StatMods.Constitution += 2;
                player.StatMods.Wisdom += 2;
                player.StatMods.Charisma -= 2;
                player.PlayerInfo.MoveSpeed = 20;
                break;
            case "ELF":
                player.PlayerInfo.Race = Race.Elf;
                player.StatMods.Dexterity = 2;
                player.StatMods.Intelligence = 2;
                player.StatMods.Constitution = -2;
                player.PlayerInfo.MoveSpeed = 30;
                break;
            case "GNOME":
                player.PlayerInfo.Race = Race.Gnome;
                player.StatMods.Strength -= 2;
                player.StatMods.Constitution += 2;
                player.StatMods.Charisma += 2;
                player.PlayerInfo.MoveSpeed = 20;
                break;
            case "HALFLING":
                player.PlayerInfo.Race = Race.Halfling;
                player.StatMods.Strength -= 2;
                player.StatMods.Dexterity += 2;
                player.StatMods.Charisma += 2;
                player.PlayerInfo.MoveSpeed = 20;
                break;
            case "HALFELF":
                player.PlayerInfo.Race = Race.HalfElf;

                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                inText = Console.ReadLine();
                switch (inText.ToUpper()) {
                    case "STR":
                        player.StatMods.Strength += 2;
                        break;
                    case "DEX":
                        player.StatMods.Dexterity += 2;
                        break;
                    case "CON":
                        player.StatMods.Constitution += 2;
                        break;
                    case "INT":
                        player.StatMods.Intelligence += 2;
                        break;
                    case "WIS":
                        player.StatMods.Wisdom += 2;
                        break;
                    case "CHA":
                        player.StatMods.Charisma += 2;
                        break;
                }
                player.PlayerInfo.MoveSpeed = 30;

                break;
            case "HALFORC":
                player.PlayerInfo.Race = Race.HalfOrc;

                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                inText = Console.ReadLine();
                switch (inText.ToUpper()) {
                    case "STR":
                        player.StatMods.Strength += 2;
                        break;
                    case "DEX":
                        player.StatMods.Dexterity += 2;
                        break;
                    case "CON":
                        player.StatMods.Constitution += 2;
                        break;
                    case "INT":
                        player.StatMods.Intelligence += 2;
                        break;
                    case "WIS":
                        player.StatMods.Wisdom += 2;
                        break;
                    case "CHA":
                        player.StatMods.Charisma += 2;
                        break;
                }
                player.PlayerInfo.MoveSpeed = 30;

                break;
            case "HUMAN":
                player.PlayerInfo.Race = Race.Human;

                Console.WriteLine("Please select a stat modifier from the following list:\nStr(ength)\nDex(terity)\nCon(stitution)\nInt(elligence)\nWis(dom)\nCha(risma)");
                inText = Console.ReadLine();
                switch (inText.ToUpper()) {
                    case "STR":
                        player.StatMods.Strength += 2;
                        break;
                    case "DEX":
                        player.StatMods.Dexterity += 2;
                        break;
                    case "CON":
                        player.StatMods.Constitution += 2;
                        break;
                    case "INT":
                        player.StatMods.Intelligence += 2;
                        break;
                    case "WIS":
                        player.StatMods.Wisdom += 2;
                        break;
                    case "CHA":
                        player.StatMods.Charisma += 2;
                        break;
                }
                player.PlayerInfo.MoveSpeed = 30;

                break;
            default:
                Commands.CheckForCommand(inText);
                break;
        }

        Console.Clear();
        Console.WriteLine("Please chooe your character's class from the following list:\nBarbarian\nBard\nCleric\nDruid\nFighter\nMonk\nPaladin\nRanger\nRogue\nSorcerer\nWizard");
        inText = Console.ReadLine();
        switch (inText.ToUpper()) {
            case "BARBARIAN":
                player.PlayerInfo.Class = Class.Barbarian;
                player.PlayerWallet.GP += Dice.Roll(6, 3) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(12, 1, player.StatMods.Constitution);
                break;
            case "BARD":
                player.PlayerInfo.Class = Class.Bard;
                player.PlayerWallet.GP += Dice.Roll(6, 3) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(8, 1, player.StatMods.Constitution);
                break;
            case "CLERIC":
                player.PlayerInfo.Class = Class.Cleric;
                player.PlayerWallet.GP += Dice.Roll(6, 4) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(8, 1, player.StatMods.Constitution);
                break;
            case "DRUID":
                player.PlayerInfo.Class = Class.Druid;
                player.PlayerWallet.GP += Dice.Roll(6, 2) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(8, 1, player.StatMods.Constitution);
                break;
            case "FIGHTER":
                player.PlayerInfo.Class = Class.Fighter;
                player.PlayerWallet.GP += Dice.Roll(6, 5) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(10, 1, player.StatMods.Constitution);
                break;
            case "MONK":
                player.PlayerInfo.Class = Class.Monk;
                player.PlayerWallet.GP += Dice.Roll(6, 1) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(8, 1, player.StatMods.Constitution);
                break;
            case "PALADIN":
                player.PlayerInfo.Class = Class.Paladin;
                player.PlayerWallet.GP += Dice.Roll(6, 5) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(10, 1, player.StatMods.Constitution);
                break;
            case "RANGER":
                player.PlayerInfo.Class = Class.Ranger;
                player.PlayerWallet.GP += Dice.Roll(6, 5) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(10, 1, player.StatMods.Constitution);
                break;
            case "ROGUE":
                player.PlayerInfo.Class = Class.Rogue;
                player.PlayerWallet.GP += Dice.Roll(6, 4) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(8, 1, player.StatMods.Constitution);
                break;
            case "SORCERER":
                player.PlayerInfo.Class = Class.Sorcerer;
                player.PlayerWallet.GP += Dice.Roll(6, 2) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(6, 1, player.StatMods.Constitution);
                break;
            case "WIZARD":
                player.PlayerInfo.Class = Class.Wizard;
                player.PlayerWallet.GP += Dice.Roll(6, 2) * 10;
                player.PlayerInfo.MaxHP = 1 + Dice.Roll(6, 1, player.StatMods.Constitution);
                break;
            default:
                Commands.CheckForCommand(inText);
                break;
        }

        player.PlayerInfo.Health = player.PlayerInfo.MaxHP;

        Console.Clear();

        player = new Player(player.PlayerInfo, player.PlayerWallet, player.Attributes, player.StatMods, player.Inventory);
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
        Console.WriteLine("|Strength                  : " + player.Attributes.Strength);
        Console.WriteLine("|Dexterity                 : " + player.Attributes.Dexterity);
        Console.WriteLine("|Constitution              : " + player.Attributes.Constitution);
        Console.WriteLine("|Intelligence              : " + player.Attributes.Intelligence);
        Console.WriteLine("|Wisdom                    : " + player.Attributes.Wisdom);
        Console.WriteLine("|Charisma                  : " + player.Attributes.Charisma);
        Console.WriteLine("==============================");

    }
}