using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Run", menuName = "Actions/Run", order = 5)]
public class SRun : SAction
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
        GameManager.Instance.UpdateText("No me atraparas con vida!");
        chase = sc.GetComponent<ChaseBehaviour>();
        enemyController = (EnemyController)sc;
        Animator animator = sc.GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetBool("idle", false);
            animator.SetBool("Attack", false);
            animator.SetBool("Die", false);
            animator.SetBool("Run", true);
        }
        else
        {
            Debug.LogError("Animator no encontrado en el StateController.");
        }
        // SoundManager.Instance.EnemyRun();
    }

    public override void OnUpdate()
    {
        try
        {
            chase.Run(enemyController.target.transform, sc.transform);
        }
        catch
        {
            chase.StopChasing();
        }
    }
}
