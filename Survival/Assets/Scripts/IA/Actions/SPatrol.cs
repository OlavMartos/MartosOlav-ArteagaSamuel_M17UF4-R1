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
        GameManager.Instance.UpdateText("patrullando la ciuda");
        Animator animator = sc.GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetBool("idle", false);
            animator.SetBool("Attack", false);
            animator.SetBool("Die", false);
            animator.SetBool("Walk", true);
        }
        else
        {
            Debug.LogError("Animator no encontrado en el StateController.");
        }
    }
}
