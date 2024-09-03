public class Enemies
{
    public static List<Enemy> enemies = new List<Enemy>();

    public static Enemy boar = new Enemy("Boar", 18, 40, 600, 17, 10, 17, 2, 13, 4);

    void AddEnemy() {
        enemies.Add(boar);
    }
    
}