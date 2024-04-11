using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Patrol", menuName = "Actions/Patrol", order = 4)]
public class SPatrol : SAction
{
    public override void OnFinishedState()
    {
        GameManager.Instance.UpdateText("Donde esta esta este tio?");
    }

    public override void OnSetState(StateController sc)
    {
        base.OnSetState(sc);
        GameManager.Instance.UpdateText("A patrullar");
    }

    public override void OnUpdate()
    {
        GameManager.Instance.UpdateText("Apatrullando la ciuda");
    }
}
