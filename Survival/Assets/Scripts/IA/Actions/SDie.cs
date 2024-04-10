using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Die", menuName = "Actions/Die", order = 2)]
public class SDie : SAction
{
    public override void OnFinishedState()
    {
        Debug.Log("Me morí");
    }

    public override void OnSetState(StateController sc)
    {
        base.OnSetState(sc);
        Debug.Log("Me derrito! Me derrito!");
    }

    public override void OnUpdate()
    {
        Debug.Log("Toma todo mi dinero");
    }
}
