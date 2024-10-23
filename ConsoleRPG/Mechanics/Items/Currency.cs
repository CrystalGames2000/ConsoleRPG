public class Currency {
    public string Name {get; set;}
    public double CopperValue {get; set;}
    public double SilverValue {get; set;}
    public double GoldValue {get; set;}
    public double PlatinumValue { get; set; }

    public Currency(string name, double copperValue, double silverValue, double goldValue, double platinumValue) {
        Name = name;
        CopperValue = copperValue;
        SilverValue = silverValue;
        GoldValue = goldValue;
        PlatinumValue = platinumValue;
    }
}