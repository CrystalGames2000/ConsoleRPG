using Newtonsoft.Json;

public static class DataManager
{
    private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Player.json");

    public static void RegisterPlayer(Player player)
    {
        try
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            string json = JsonConvert.SerializeObject(player, Formatting.Indented, settings);
            File.WriteAllText(path, json);
            Console.WriteLine("Players saved to JSON file successfully in " + path);
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error saving JSON file: {e.Message}");
        }
    }
}