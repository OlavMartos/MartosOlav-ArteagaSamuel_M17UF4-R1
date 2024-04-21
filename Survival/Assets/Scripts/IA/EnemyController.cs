using UnityEngine;
using UnityEngine.UI;

public class EnemyController : StateController
{
    public float AttackDistance;
    public float HP;
    private float maxHP = 100f; 
    private Animator anim;
    public Image healthBar;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        StateTransition();
        if (currentState.action != null) currentState.action.OnUpdate();

        if((currentState.name == "Chase" || currentState.name == "Run") && Input.GetKey(KeyCode.J) && Time.time >= nextHurt)

        {
            OnHurt(10); 
            UpdateHealthBarInstant(); 
        }

        if (currentState.name == "Run") target = null;
    }

    public void OnHurt(float damage)
    {
        HP -= damage;
        HP = Mathf.Clamp(HP, 0, maxHP);
    }

    private void UpdateHealthBarInstant()
    {
        
        healthBar.fillAmount = HP / maxHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) target = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) target = null;
    }
}

