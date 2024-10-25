public class Weapons
{
    public static Weapon gauntlet =          new Weapon(null, null, 1, "Gauntlet",           2,   "1d2",  "1d3",  "x2",       null, 1.0,  ["B"],      null             );
    public static Weapon unarmedStrike =     new Weapon(null, null, 1, "Unarmed Strike",     0,   "1d2",  "1d3",  "x2",       null, 0.0,  ["B"],      ["Nonlethal"]    );
    public static Weapon dagger =            new Weapon(null, null, 1, "Dagger",             2,   "1d3",  "1d4",  "19-20/x2", 10,   1.0,  ["P","S"],  null             );
    public static Weapon punchingDagger =    new Weapon(null, null, 1, "Punching Dagger",    2,   "1d3",  "1d4",  "x3",       null, 1.0,  ["P"],      null             );
    public static Weapon spikedGauntlet =    new Weapon(null, null, 1, "Spiked Gauntlet",    5,   "1d3",  "1d4",  "x2",       null, 1.0,  ["P"],      null             );
    public static Weapon lightMace =         new Weapon(null, null, 1, "Light Mace",         5,   "1d4",  "1d6",  "x2",       null, 4.0,  ["B"],      null             );
    public static Weapon sickle =            new Weapon(null, null, 1, "Sickle",             6,   "1d4",  "1d6",  "x2",       null, 2.0,  ["S"],      null             );
    public static Weapon club =              new Weapon(null, null, 1, "Club",               0,   "1d4",  "1d6",  "x2",       10,   3.0,  ["B"],      null             );
    public static Weapon shortspear =        new Weapon(null, null, 1, "Shortspear",         1,   "1d4",  "1d6",  "x2",       20,   3.0,  ["P"],      null             );
    public static Weapon longSpear =         new Weapon(null, null, 1, "Longspear",          5,   "1d6",  "1d8",  "x3",       null, 9.0,  ["P"],      null             );
    public static Weapon quarterstaff =      new Weapon(null, null, 1, "Quarterstaff",       0,   "1d4",  "1d6",  "x2",       null, 4.0,  ["B"],      ["Double weapon"]);
    public static Weapon spear =             new Weapon(null, null, 1, "Spear",              2,   "1d6",  "1d8",  "x3",       20,   6.0,  ["P"],      null             );
    public static Weapon heavyMace =         new Weapon(null, null, 1, "Heavy Mace",         12,  "1d6",  "1d8",  "x2",       null, 8.0,  ["B"],      null             );
    public static Weapon morningstar =       new Weapon(null, null, 1, "Morningstar",        8,   "1d6",  "1d8",  "x2",       null, 6.0,  ["B","P"],  null             );
    public static Weapon shortsword =        new Weapon(null, null, 1, "Shortsword",         10,  "1d4",  "1d6",  "19-20/x2", null, 2.0,  ["P"],      null             );
    public static Weapon battleaxe =         new Weapon(null, null, 1, "Battleaxe",          10,  "1d6",  "1d8",  "x3",       null, 6.0,  ["S"],      null             );
    public static Weapon flail =             new Weapon(null, null, 1, "Flail",              8,   "1d6",  "1d8",  "x2",       null, 5.0,  ["B"],      null             );
    public static Weapon longsword =         new Weapon(null, null, 1, "Longsword",          15,  "1d6",  "1d8",  "19-20/x2", null, 4.0,  ["S"],      null             );
    public static Weapon scimitar =          new Weapon(null, null, 1, "Scimitar",           15,  "1d4",  "1d6",  "18-20/x2", null, 4.0,  ["S"],      null             );
    public static Weapon throwingAxe =       new Weapon(null, null, 1, "Throwing Axe",       8,   "1d4",  "1d6",  "x2",       10,   2.0,  ["S"],      null             );
    public static Weapon warhammer =         new Weapon(null, null, 1, "Warhammer",          12,  "1d6",  "1d8",  "x3",       null, 5.0,  ["B"],      null             );
    public static Weapon falchion =          new Weapon(null, null, 1, "Falchion",           75,  "1d6",  "2d4",  "18-20/x2", null, 8.0,  ["S"],      null             );
    public static Weapon glaive =            new Weapon(null, null, 1, "Glaive",             8,   "1d8",  "1d10", "x3",       null, 10.0, ["S"],      null             );
    public static Weapon greataxe =          new Weapon(null, null, 1, "Greataxe",           20,  "1d10", "1d12", "x3",       null, 12.0, ["S"],      null             );
    public static Weapon greatclub =         new Weapon(null, null, 1, "Greatclub",          5,   "1d8",  "1d10", "x2",       null, 8.0,  ["B"],      null             );
    public static Weapon greatsword =        new Weapon(null, null, 1, "Greatsword",         50,  "1d10", "2d6",  "19-20/x2", null, 8.0,  ["S"],      null             );
    public static Weapon guisarme =          new Weapon(null, null, 1, "Guisarme",           9,   "1d6",  "2d4",  "x3",       null, 12.0, ["S"],      null             );
    public static Weapon halberd =           new Weapon(null, null, 1, "Halberd",            10,  "1d8",  "1d10", "x3",       null, 12.0, ["P","S"],  null             );
    public static Weapon lance =             new Weapon(null, null, 1, "Lance",              10,  "1d6",  "1d8",  "x3",       null, 10.0, ["P"],      ["Reach"]        );
    public static Weapon ranseur =           new Weapon(null, null, 1, "Ranseur",            10,  "1d6",  "2d4",  "x3",       null, 12.0, ["P"],      null             );
    public static Weapon scythe =            new Weapon(null, null, 1, "Scythe",             18,  "2d4",  "2d4",  "x4",       null, 10.0, ["P", "S"], null             );
    public static Weapon shortbow =          new Weapon(null, null, 1, "Shortbow",           30,  "1d4",  "1d6",  "x3",       60,   2.0,  ["P"],      null             );
    public static Weapon compositeShortbow = new Weapon(null, null, 1, "Composite Shortbow", 75,  "1d4",  "1d6",  "x3",       70,   2.0,  ["P"],      null             );
    public static Weapon longbow =           new Weapon(null, null, 1, "Longbow",            75,  "1d6",  "1d8",  "x3",       100,  3.0,  ["P"],      null             );
    public static Weapon compositeLongbow =  new Weapon(null, null, 1, "Composite Longbow",  100, "1d6",  "1d8",  "x3",       110,  3.0,  ["P"],      null             );
}
