using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform checkpoint;
    private PlayerMovement movement;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    public void Respawn()
    {
        // will respawn the player at the last known checkpoint

        // it stops all existing movment.
        movement.moveDirection = Vector3.zero;
        GetComponent<CharacterController>().enabled = false;
        // move the player backup
        transform.position = checkpoint.position;
        GetComponent<CharacterController>().enabled = true;
        // rotatate player
        transform.rotation = checkpoint.rotation;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Respawn();

        }
    }
}
