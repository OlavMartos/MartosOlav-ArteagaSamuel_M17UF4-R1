using UnityEngine;

[CreateAssetMenu(fileName = "Attack", menuName = "Actions/Attack", order = 1)]
public class SAttack : SAction
{
    public override void OnFinishedState()
    {
        GameManager.Instance.UpdateText("Te perdono la vida");
    }

    public override void OnSetState(StateController sc)
    {
        base.OnSetState(sc);
        GameManager.Instance.UpdateText("A que te doy");
    }

    public override void OnUpdate()
    {
        GameManager.Instance.UpdateText("Que te meto asin");
    }
}
