using System.Threading.Tasks.Dataflow;

namespace iThinkSoQuestionMark;

public class Items
{
    public bool IsEdible;
    public int SelfDamage;
    public int Damage;
    public float Weight;
    public bool Stackable;
    public int Healing;

}
public class Character{
    public int Health;
    public int Damage;
    public int Speed;
}
public class Weapons{
    public int Damage;
    public int Range;
    public bool HasDurability;
}


public class MeleeEnemy
{
    public int Damage;
    public int Health;
    public int Speed;
    public float IntSpawnCost;
}
