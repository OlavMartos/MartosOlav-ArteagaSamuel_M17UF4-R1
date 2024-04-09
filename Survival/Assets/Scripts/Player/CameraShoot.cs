using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraShoot : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera aimVirtualCamera;
    [SerializeField] private float rotationSpeed = 0.25f;
    public float mouseSensitivity = 100f;

    float xRotation = 0f;
    float YRotation = 0f;
    private Player player;
    private Transform cameraPosition;
    public GameObject mira;

    // Start is called before the first frame update
    private void Awake()
    {
        player= GetComponent<Player>();
        cameraPosition = Camera.main.transform;

    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mira.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if (player.Apuntar)
        {
            aimVirtualCamera.gameObject.SetActive(true);
            mira.SetActive(true);


            //Rotacion de la camara primera persona
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -100f, 10f);
            YRotation += mouseX;
            transform.localRotation = Quaternion.Euler(xRotation, YRotation, 0f);
        }
        else
        {
            mira.SetActive(false);
            aimVirtualCamera.gameObject.SetActive(false);
        }
    }
}

