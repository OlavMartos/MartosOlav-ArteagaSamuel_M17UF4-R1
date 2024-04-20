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

        
        if (Input.GetKeyDown(KeyCode.J))
        {
            OnHurt(10); 
            UpdateHealthBarInstant(); 
        }
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

