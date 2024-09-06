public class Enemy(string name, int health, int speed, int xp, int str, int dex, int con, int intelligence, int wis, int cha)
{
    public string name = name;
    public int health = health;
    public int damage;
    public int speed = speed;
    public int xp = xp;

    public int enemyStr = str;
    public int enemyDex = dex;
    public int enemyCon = con;
    public int enemyInt = intelligence;
    public int enemyWis = wis;
    public int enemyCha = cha;

    private PlayerData player;

    public void Attack(Enemy enemy) {
        player.PlayerHealth -= enemy.damage;
    }

    public void Die(Enemy enemy) {
        player.PlayerXP += enemy.xp;
    }
}
