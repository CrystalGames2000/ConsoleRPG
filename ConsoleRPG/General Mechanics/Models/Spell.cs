public class Spell
{
    public SpellInfo SpellInfo { get; set; }
    public SpellLevels ClassLevels { get; set; }

    public Spell(SpellInfo spellInfo,SpellLevels classLevels) {
        SpellInfo = spellInfo;
        ClassLevels = classLevels;
    }
}

public class SpellInfo
{
    public string Name { get; set; }
    public string School { get; set; }
    public string Description { get; set; }

    public SpellInfo(string name, string school, string description) {
        Name = name;
        School = school;
        Description = description;
    }
}
public class SpellLevels
{
    public int Barbarian { get; set; }
    public int Bard {get; set; }
    public int Cleric { get; set; }
    public int Druid { get; set; }
    public int Fighter { get; set; }
    public int Monk { get; set; }
    public int Paladin { get; set; }
    public int Ranger { get; set; }
    public int Rogue { get; set; }
    public int Sorcerer { get; set; }
    public int Wizard { get; set; }

    public SpellLevels(int barbarian, int bard, int cleric, int druid, int fighter, int monk, int paladin, int ranger, int rogue, int sorcerer, int wizard) {
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
    }
}