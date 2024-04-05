using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X");
        RotateCharacter(mouseXMove);
    }

    void RotateCharacter(float mouseXMove)
    {
        Vector3 rotation = new Vector3 (0, mouseXMove * speedRotation, 0);
        transform.Rotate(rotation);
    }
}
