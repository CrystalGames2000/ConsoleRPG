using System.Text.Json;

public static class DataManager
{
    public static async void RegisterNewPlayer(PlayerData player, int saveSlot) {
        List<PlayerData> players = new List<PlayerData>();
        players.Add(new PlayerData() {
            PlayerFirstName = player.PlayerFirstName,
            PlayerLastName = player.PlayerLastName,
            PlayerRace = player.PlayerRace.ToUpper(),
            PlayerClass = player.PlayerClass.ToUpper(),
            PlayerLevel = player.PlayerLevel,
            PlayerXP = player.PlayerXP,
            PlayerHealth = player.PlayerHealth,
            PlayerStrMod = player.PlayerStrMod,
            PlayerDexMod = player.PlayerDexMod,
            PlayerConMod = player.PlayerConMod,
            PlayerIntMod = player.PlayerIntMod,
            PlayerWisMod = player.PlayerWisMod,
            PlayerChaMod = player.PlayerChaMod,
            PlayerStr = player.PlayerStr,
            PlayerDex = player.PlayerDex,
            PlayerCon = player.PlayerCon,
            PlayerInt = player.PlayerInt,
            PlayerWis = player.PlayerWis,
            PlayerCha = player.PlayerCha
        });

        var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var appFolder = Path.Combine(appData, "ConsoleRPG");
        _ = Directory.CreateDirectory(appFolder);
        var myFile = Path.Combine(appFolder, "Players.json");

        await using FileStream createStream = File.Create(myFile);
        await JsonSerializer.SerializeAsync(createStream, players);
    }

    public static void LoginPlayer(PlayerData player) {

    }

    public static void UpdatePlayerHealth(PlayerData player) {

    }

    public static void UpdatePlayerXP(PlayerData player) {

    }
}
