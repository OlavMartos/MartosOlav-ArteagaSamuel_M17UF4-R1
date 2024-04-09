using UnityEngine;

[CreateAssetMenu(fileName = "Follow", menuName = "Nodes/Conditions/Follow")]
public class CheckFollow : SConditional
{
    public override bool Check(StateController sc)
    {
        var enemyContr = (EnemyController)sc;
        try
        {
            return (sc.target.transform.position - sc.transform.position).magnitude > enemyContr.AttackDistance;
        }
        catch { return false; }
    }
}
