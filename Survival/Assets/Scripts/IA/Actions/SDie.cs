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
        // SoundManager.Instance.EnemyDeath();
    }

    public override void OnUpdate()
    {
        GameManager.Instance.UpdateText("Toma todo mi dinero");
        Animator animator = sc.GetComponent<Animator>();
        if (animator != null)
        {

            animator.SetBool("Run", false);
            animator.SetBool("Walk", false);
            animator.SetBool("idle", false);
            animator.SetBool("Attack", false);
            animator.SetBool("Die", true);
        }
    }
}
