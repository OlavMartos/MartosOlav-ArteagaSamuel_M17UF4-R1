using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Follow", menuName = "Actions/Follow", order = 3)]
public class SFollow : SAction
{
    private ChaseBehaviour chase;
    private EnemyController enemyController;

    public override void OnFinishedState()
    {
        chase.StopChasing();
    }

    public override void OnSetState(StateController sc)
    {
        base.OnSetState(sc);
        GameManager.Instance.UpdateText("Voy por ti");
        chase = sc.GetComponent<ChaseBehaviour>();
        enemyController = (EnemyController)sc;
    }

    public override void OnUpdate()
    {
        chase.Chase(enemyController.target.transform, sc.transform);
    }
}
