public class ItemDataManager
{
    private static string path = Path.Combine(Directory.GetCurrentDirectory(),"GameData");

    public static async void LoadWeapons(List<Weapon> weapons) {
        path = string.Join("", path, "\\Weapons.json");

        string jsonString = await File.ReadAllTextAsync(path);
        foreach (Weapon weapon in weapons) {
            weapons.Add(weapon);
        }
    }

    public static void DisplayWeapons(List<Weapon> weapons) {
        foreach (Weapon weapon in weapons) {
            Console.WriteLine(weapon);
        }
    }
}