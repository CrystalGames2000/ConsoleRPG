public class Weapon: Item
{
    string Item.Name { get; set; }

    int? Cost { get; set; }
    string? DmgS {  get; set; }
    string? DmgM { get; set; }
    int? Critical {  get; set; }
    int? Range { get; set; }
    int? Weight { get; set; }
    string? Type { get; set; }
    string[]? Special {  get; set; }
}