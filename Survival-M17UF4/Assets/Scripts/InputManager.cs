using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public bool Apuntar;
    private InputAction apuntarAction;
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        apuntarAction = playerInput.actions.FindAction("Aim");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //1er Persona
    public void OnApuntar(InputValue value)
    {
        ApuntarInput(value.isPressed);
    }
    public void ApuntarInput(bool newAimState)
    {
        Apuntar = newAimState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
