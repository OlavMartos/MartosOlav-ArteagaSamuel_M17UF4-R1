using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "Actions/Attack", order = 1)]
public class SAttack : SAction
{
    public override void OnFinishedState()
    {
        Debug.Log("Te perdono la vida");
    }

    public override void OnSetState(StateController sc)
    {
        base.OnSetState(sc);
        Debug.Log("A que te doy");
    }

    public override void OnUpdate()
    {
        Debug.Log("Que te meto asin");
    }
}
