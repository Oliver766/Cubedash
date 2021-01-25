using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingCubes: MonoBehaviour
{


    public int Damage;

    private void OnCollisionEnter(Collision player)
    {
       if (player.gameObject.CompareTag("Player"))
       {
            PlayerHealth Health = player.gameObject.GetComponent<PlayerHealth>();
            Health.ChangeHealth(-Damage);
            


        }

    }



}
