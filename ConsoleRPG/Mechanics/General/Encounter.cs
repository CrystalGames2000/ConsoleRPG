﻿public class Encounter
{
    Player player = new PlayerData(Game.player);
    public static void EnemyEncounter(Enemy enemy) {
        Console.WriteLine("You have encountered ", enemy.name);
        enemy.Attack(Enemies.boar);
    }
}