using UnityEngine;

[CreateAssetMenu(fileName = "Run", menuName = "Nodes/Conditions/Run")]
public class CheckRun : SConditional
{
    public override bool Check(StateController sc)
    {
        var enemyContr = (EnemyController)sc;
        return enemyContr.HP < 3;
    }
}
