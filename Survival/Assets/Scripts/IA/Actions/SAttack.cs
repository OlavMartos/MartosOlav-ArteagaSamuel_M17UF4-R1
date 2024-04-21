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
        // SoundManager.Instance.EnemyAttack();
    }

    public override void OnUpdate()
    {
        GameManager.Instance.UpdateText("Que te meto asi");
        Animator animator = sc.GetComponent<Animator>();
        if (animator != null)
        {
            Debug.Log("Se ha activado el ataque");
            animator.SetBool("Run", false);
            animator.SetBool("Walk", false);
            animator.SetBool("idle", false);
            animator.SetBool("Die", false);
            animator.SetBool("Attack", true);
            UIManager.instance.GameOver();
        }
        else
        {
            Debug.LogError("Animator no encontrado en el StateController.");
        }
    }
}
