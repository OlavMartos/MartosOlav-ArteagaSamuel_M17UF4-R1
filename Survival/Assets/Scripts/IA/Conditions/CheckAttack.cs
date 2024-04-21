using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "Nodes/Conditions/Attack")]
public class CheckAttack : SConditional
{
    public override bool Check(StateController sc)
    {
        var enemyContr = (EnemyController)sc;
        try
        {
            return (sc.target.transform.position - sc.transform.position).magnitude <= enemyContr.AttackDistance;
        }
        catch { return false; }
    }
}
