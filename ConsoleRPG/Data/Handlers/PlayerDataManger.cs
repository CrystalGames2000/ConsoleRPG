using System.Text.Json;

public class PlayerDataManager
{
    private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ConsoleRPG");

    public static void DisplayPlayerStats(Player player) {
        Console.WriteLine("=======================");
        Console.WriteLine("|First Name  : " + player.FirstName);
        Console.WriteLine("|Last Name   : " + player.LastName);
        Console.WriteLine("|Race        : " + player.Race);
        Console.WriteLine("|Class       : " + player.Class);
        Console.WriteLine("|Level       : " + player.Level);
        Console.WriteLine("|Experience  : " + player.XP);
        Console.WriteLine("|Copper      : " + player.CP);
        Console.WriteLine("|Silver      : " + player.SP);
        Console.WriteLine("|Gold        : " + player.GP);
        Console.WriteLine("|Platinum    : " + player.PP);
        Console.WriteLine("|Move Speed  : " + player.MoveSpeed);
        Console.WriteLine("|Health      : " + player.Health);
        Console.WriteLine("|Strength Mod: " + player.StrMod);
        Console.WriteLine("|Mod         : " + player.DexMod);
        Console.WriteLine("|Mod         : " + player.ConMod);
        Console.WriteLine("|Mod         : " + player.IntMod);
        Console.WriteLine("|Mod         : " + player.WisMod);
        Console.WriteLine("|Mod         : " + player.ChaMod);
        Console.WriteLine("|Strength    : " + player.Strength);
        Console.WriteLine("|Dexterity   : " + player.Dexterity);
        Console.WriteLine("|Constitution: " + player.Constitution);
        Console.WriteLine("|Intelligence: " + player.Intelligence);
        Console.WriteLine("|Wisdom      : " + player.Wisdom);
        Console.WriteLine("|Charisma    : " + player.Charisma);
        Console.WriteLine("=======================");

    }

    public static void RegisterPlayer(Player player) {
        if (!Directory.Exists(path)) {
            Directory.CreateDirectory(path);
            path = string.Join("", path, "\\Players.json");
        }
        string jsonString = JsonSerializer.Serialize(player);
        File.WriteAllTextAsync(path, jsonString);
    }

    public static async void LoginPlayer(Player player) {
        if (!Directory.Exists(path)) {
            Directory.CreateDirectory(path);
            path = string.Join("", path, "\\Players.json");
        }
        string jsonString = await File.ReadAllTextAsync(path);
        player = JsonSerializer.Deserialize<Player>(jsonString);
    }
}