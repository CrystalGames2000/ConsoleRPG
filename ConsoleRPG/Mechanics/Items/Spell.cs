using System;

public class Spell
{
    string? Name { get; set; }
    string? School { get; set; }
    string? CastingTime { get; set; }
    int? CostlyComponents { get; set; }
    string? Range { get; set; }
    string? Area { get; set; }
    string? Effect { get; set; }
    string? Targets { get; set; }
    string? Duration { get; set; }
    string? Dismissible { get; set; }
    string? Shapeable { get; set; }
    string? SavingThrow { get; set; }
    string? SpellResistance { get; set; }
    string? Description { get; set; }
    string? Verbal { get; set; }
    string? Somatic { get; set; }
    string? Material { get; set; }
    string? Focus { get; set; }
    string? DivineFocus { get; set; }
    string? Sor { get; set; }
    string? Wiz { get; set; }
    string? Cleric { get; set; }
    string? Druid { get; set; }
    string? Ranger { get; set; }
    string? Bard { get; set; }
    string? Paladin { get; set; }
    string? SLALevel { get; set; }
    string? Domain { get; set; }
    string? Acid { get; set; }
    string? Air { get; set; }
    string? Chaotic { get; set; }
    string? Cold { get; set; }
    string? Curse { get; set; }
    string? Darkness { get; set; }
    string? Death { get; set; }
    string? Disease { get; set; }
    string? Earth { get; set; }
    string? Electricity { get; set; }
    string? Emotion { get; set; }
    string? Evil { get; set; }
    string? Fear { get; set; }
    string? Fire { get; set; }
    string? Force { get; set; }
    string? Good { get; set; }
    string? LanguageDependent { get; set; }
    string? Lawful { get; set; }
    string? Light { get; set; }
    string? MindAffecting { get; set; }
    string? Pain { get; set; }
    string? Poison { get; set; }
    string? Shadow { get; set; }
    string? Sonic { get; set; }
    string? Water { get; set; }
    string? Linktext { get; set; }
    string? Id { get; set; }
    string? MaterialCosts { get; set; }
    string? Mythic { get; set; }

    public Spell(string? name, string? school, string? castingTime, int? costlyComponents, string? range, string? area, string? effect, string? targets, string? duration, string? dismissible, string? shapeable, string? savingThrow, string? spellResistance, string? description, string? verbal, string? somatic, string? material, string? focus, string? divineFocus, string? sor, string? wiz, string? cleric, string? druid, string? ranger, string? bard, string? paladin, string? sLALevel, string? domain, string? acid, string? air, string? chaotic, string? cold, string? curse, string? darkness, string? death, string? disease, string? earth, string? electricity, string? emotion, string? evil, string? fear, string? fire, string? force, string? good, string? languageDependent, string? lawful, string? light, string? mindAffecting, string? pain, string? poison, string? shadow, string? sonic, string? water, string? linktext, string? id, string? materialCosts, string? mythic) {
        Name = name;
        School = school;
        CastingTime = castingTime;
        CostlyComponents = costlyComponents;
        Range = range;
        Area = area;
        Effect = effect;
        Targets = targets;
        Duration = duration;
        Dismissible = dismissible;
        Shapeable = shapeable;
        SavingThrow = savingThrow;
        SpellResistance = spellResistance;
        Description = description;
        Verbal = verbal;
        Somatic = somatic;
        Material = material;
        Focus = focus;
        DivineFocus = divineFocus;
        Sor = sor;
        Wiz = wiz;
        Cleric = cleric;
        Druid = druid;
        Ranger = ranger;
        Bard = bard;
        Paladin = paladin;
        SLALevel = sLALevel;
        Domain = domain;
        Acid = acid;
        Air = air;
        Chaotic = chaotic;
        Cold = cold;
        Curse = curse;
        Darkness = darkness;
        Death = death;
        Disease = disease;
        Earth = earth;
        Electricity = electricity;
        Emotion = emotion;
        Evil = evil;
        Fear = fear;
        Fire = fire;
        Force = force;
        Good = good;
        LanguageDependent = languageDependent;
        Lawful = lawful;
        Light = light;
        MindAffecting = mindAffecting;
        Pain = pain;
        Poison = poison;
        Shadow = shadow;
        Sonic = sonic;
        Water = water;
        Linktext = linktext;
        Id = id;
        MaterialCosts = materialCosts;
        Mythic = mythic;
    }
}