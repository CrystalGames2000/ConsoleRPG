using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

public static class DataManager
{
    public static async void RegisterNewPlayer(PlayerData player) {
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

        string json = JsonConvert.SerializeObject(players.ToArray());

        File.WriteAllText(@$"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Players.json", json);
    }

    public static void LoginPlayer(PlayerData player) {
        
    }

    public static void UpdatePlayerHealth(PlayerData player) {

    }

    public static void UpdatePlayerXP(PlayerData player) {

    }
}
