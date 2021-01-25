using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health;
    public float HealthMin = 0;
    public float HealthMax = 100;

    public PlayerRespawn playerRespawn;

    public void ChangeHealth(int amount)
    {
        if (Health + amount > HealthMax)
        {
            Health = HealthMax;
            
        }

        else if (Health + amount <= HealthMin)
        {
            
            
       
            PlayerRespawn respawn = GetComponent<PlayerRespawn>();
            respawn.Respawn();
            Health = HealthMax;
            

        }
        else
        {
            Health += amount;
            
        }


    }
}
