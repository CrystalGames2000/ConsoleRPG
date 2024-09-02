﻿public class PlayerData
{
    public string PlayerFirstName { get; set; }
    public string PlayerLastName { get; set; }
    public string PlayerRace { get; set; }
    public string PlayerClass { get; set; }
    public int PlayerLevel { get; set; }
    public int PlayerXP { get; set; }
    public int PlayerHealth { get; set; }
    public int PlayerStrMod { get; set; }
    public int PlayerDexMod { get; set; }
    public int PlayerConMod { get; set; }
    public int PlayerIntMod { get; set; }
    public int PlayerWisMod { get; set; }
    public int PlayerChaMod { get; set; }
    public int PlayerStr { get; set; }
    public int PlayerDex { get; set; }
    public int PlayerCon { get; set; }
    public int PlayerInt { get; set; }
    public int PlayerWis { get; set; }
    public int PlayerCha { get; set; }

    private PlayerData player;

    public PlayerData() {
    }

    public PlayerData(PlayerData player) {
        this.player = player;
    }
}