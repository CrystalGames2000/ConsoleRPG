public class EntityWallet
{
    public int CP { get; set; }
    public int SP { get; set; }
    public int GP { get; set; }
    public int PP { get; set; }

    public EntityWallet(int cp, int sp, int gp, int pp) {
        CP = cp;
        SP = sp;
        GP = gp;
        PP = pp;
    }
}