using UnityEngine;

public class EnemyController : StateController
{
    public float AttackDistance;
    public float HP;
    private float nextHurt = 0;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        StateTransition();
        if (currentState.action != null) currentState.action.OnUpdate();
        if(Input.GetKey(KeyCode.J) && Time.time >= nextHurt)
        {
            OnHurt(1);
            nextHurt = Time.time + 0.3f;
        }
    }

    public void OnHurt(float damage)
    {
        HP -= damage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) target = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")) target = null;
    }
}
