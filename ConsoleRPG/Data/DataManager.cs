//FINISH AFTER BASE GAME IS DONE
/*using System.Text;
using System.Text.Json;

public static class DataManager
{

    public static string saveSlot;

    public static string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ConsoleRPG",$"Player{saveSlot}");

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

        var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var appFolder = Path.Combine(appData, "ConsoleRPG");
        _ = Directory.CreateDirectory(appFolder);
        var myFile = Path.Combine(appFolder, "Players.json");
        switch (saveSlot) {
            case "1":
                myFile = Path.Combine(appFolder, "Player1.json");
                break;
            case "2":
                myFile = Path.Combine(appFolder, "Player2.json");
                break;
            case "3":
                myFile = Path.Combine(appFolder, "Player3.json");
                break;
            case "4":
                myFile = Path.Combine(appFolder, "Player4.json");
                break;
            case "5":
                myFile = Path.Combine(appFolder, "Player5.json");
                break;
            case "6":
                myFile = Path.Combine(appFolder, "Player6.json");
                break;
        }


        await using FileStream createStream = File.Create(myFile);
        await JsonSerializer.SerializeAsync(createStream, players);
    }

    public static void LoginPlayer(PlayerData player) {

        PlayerData? loggedPlayer = JsonSerializer.Deserialize<PlayerData>(saveSlot);
        switch (saveSlot) {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
        }
    }

    public static void UpdatePlayerHealth(PlayerData player) {

    }

    public static void UpdatePlayerXP(PlayerData player) {

    }

    public static void ReadImage(string path) {
        
    }
}
*/