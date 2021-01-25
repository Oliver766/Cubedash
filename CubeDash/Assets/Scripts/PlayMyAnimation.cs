using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour
{
    public Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myAnimationController.SetBool("FloorCollapse", true);
            Debug.Log("Enter");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            myAnimationController.SetBool("FloorCollapse", false);
            Debug.Log("Exit");
        }

    }
}
