using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    public GameObject myTrigger;

    
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Menu");
            Debug.LogError("Endgame");

        }
    }
}
