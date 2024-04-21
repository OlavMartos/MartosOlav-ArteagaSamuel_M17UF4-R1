using UnityEngine;

[CreateAssetMenu(fileName = "Target", menuName = "Nodes/Conditions/Target")]
public class CheckTarget : SConditional
{
    public override bool Check(StateController sc)
    {
        return sc.target != null;
    }
}
