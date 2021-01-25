using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerRespawn respawn = other.GetComponent<PlayerRespawn>();
            respawn.Respawn();


        }
            
          
    }
}