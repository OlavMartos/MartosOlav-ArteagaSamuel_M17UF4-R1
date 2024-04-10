using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Die", menuName = "Actions/Die", order = 2)]
public class SDie : SAction
{
    public override void OnFinishedState()
    {
        GameManager.Instance.UpdateText("Me morí");
    }

    public override void OnSetState(StateController sc)
    {
        base.OnSetState(sc);
        GameManager.Instance.UpdateText("Me derrito! Me derrito!");
    }

    public override void OnUpdate()
    {
        GameManager.Instance.UpdateText("Toma todo mi dinero");
    }
}
