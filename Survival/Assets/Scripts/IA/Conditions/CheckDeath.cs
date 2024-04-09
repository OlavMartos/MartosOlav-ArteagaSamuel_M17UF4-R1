using UnityEngine;

[CreateAssetMenu(fileName = "Death", menuName = "Nodes/Conditions/Death")]
public class CheckDeath : SConditional
{
    public override bool Check(StateController sc)
    {
        var enemyContr = (EnemyController)sc;
        return enemyContr.HP <= 0;
    }
}
