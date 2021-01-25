using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{

    public CharacterController characterController;
    private void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {

            characterController.height = 1f;

        }
        else
        {
            characterController.height = 1.8f;

        }
    }
}
