using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject camera;
    public float mouseSensitivty = 100f;
    float xRotation = 0f;

    CharacterController CharacterController;

    public float speed = 12f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
   

    public Vector3 moveDirection = Vector3.zero;

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        CharacterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (CharacterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes


            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            moveDirection = transform.right * x + transform.forward * z;
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }


        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        CharacterController.Move(moveDirection * Time.deltaTime);

        // Looking left and right
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivty * Time.deltaTime;
        transform.Rotate(0, mouseX, 0);

        // Look up and down
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivty * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}



