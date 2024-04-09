using UnityEngine;

[CreateAssetMenu(fileName = "Target", menuName = "Nodes/Conditions/Root")]
public class CheckRoot : SConditional
{
    public override bool Check(StateController sc)
    {
        return true;
    }
}
