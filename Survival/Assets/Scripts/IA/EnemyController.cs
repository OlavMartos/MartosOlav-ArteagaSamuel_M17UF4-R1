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
        if((currentState.name == "Chase" || currentState.name == "Run") && Input.GetKey(KeyCode.J) && Time.time >= nextHurt)
        {
            OnHurt(1);
            nextHurt = Time.time + 0.3f;
        }

        if (currentState.name == "Run") target = null;
    }

    public void OnHurt(float damage)
    {
        if (HP - damage >= 0)
        {
            HP -= damage;
        }
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
