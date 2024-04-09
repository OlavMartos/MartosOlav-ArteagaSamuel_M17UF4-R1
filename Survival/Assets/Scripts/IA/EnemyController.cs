using UnityEngine;

public class EnemyController : StateController
{
    public float AttackDistance;
    public float HP;
    private float nextHurt = 0;

    private void Update()
    {
        StateTransition();
        if (currentState.action != null) currentState.action.OnUpdate();
        if(Input.GetKey("J") && Time.time >= nextHurt)
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
        target = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        target = null;
    }
}
