public class Skill
{
    public string Name { get; set; }
    public bool Barbarian { get; set; }
    public bool Bard { get; set; }
    public bool Cleric { get; set; }
    public bool Druid { get; set; }
    public bool Fighter { get; set; }
    public bool Monk { get; set; }
    public bool Paladin { get; set; }
    public bool Ranger { get; set; }
    public bool Rogue { get; set; }
    public bool Sorcerer { get; set; }
    public bool Wizard { get; set; }
    public bool Untrained { get; set; }
    public string Ability { get; set; }

    public Skill(string name, bool barbarian, bool bard, bool cleric, bool druid, bool fighter, bool monk, bool paladin, bool ranger, bool rogue, bool sorcerer, bool wizard, bool untrained, string ability) {
        Name = name;
        Barbarian = barbarian;
        Bard = bard;
        Cleric = cleric;
        Druid = druid;
        Fighter = fighter;
        Monk = monk;
        Paladin = paladin;
        Ranger = ranger;
        Rogue = rogue;
        Sorcerer = sorcerer;
        Wizard = wizard;
        Untrained = untrained;
        Ability = ability;
    }
}