public class Enemy
{
    public string name;
    public int health;
    public int damage;
    public int speed;
    public int xp;

    public int enemyStr;
    public int enemyDex;
    public int enemyCon;
    public int enemyInt;
    public int enemyWis;
    public int enemyCha;

    public PlayerData player = new(Game.player);
    public Enemy(string name, int health, int speed, int xp, int str, int dex, int con, int intelligence, int wis, int cha, PlayerData player) {
        this.name = name;
        this.health = health;
        this.speed = speed;
        this.xp = xp;
        this.enemyStr = str;
        this.enemyDex = dex;
        this.enemyCon = con;
        this.enemyInt = intelligence;
        this.enemyWis = wis;
        this.enemyCha = cha;
        this.player = player;
    }

    public void Attack(Enemy enemy) {
        player.PlayerHealth -= enemy.damage;
        DataManager.UpdatePlayerHealth(player);

    }

    public void Die(Enemy enemy) {
        player.PlayerXP += enemy.xp;
        DataManager.UpdatePlayerXP(player);
    }
}
