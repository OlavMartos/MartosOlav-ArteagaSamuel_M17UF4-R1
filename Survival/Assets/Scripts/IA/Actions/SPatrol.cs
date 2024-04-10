using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Patrol", menuName = "Actions/Patrol", order = 4)]
public class SPatrol : SAction
{
    public override void OnFinishedState()
    {
        Debug.Log("Donde esta esta este tio?");
    }

    public override void OnSetState(StateController sc)
    {
        base.OnSetState(sc);
        Debug.Log("A patrullar");
    }

    public override void OnUpdate()
    {
        Debug.Log("Apatrullando la ciuda");
    }
}
