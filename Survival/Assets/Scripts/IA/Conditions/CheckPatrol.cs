using UnityEngine;

[CreateAssetMenu(fileName = "Patrol", menuName = "Nodes/Conditions/Patrol")]
public class CheckPatrol : SConditional
{
    public override bool Check(StateController sc)
    {
        return sc.target == null;
    }
}
