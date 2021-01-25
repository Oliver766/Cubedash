using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public PlayerHealth PlayerHealth;
    public RectTransform bar;


    
    public void Update()
    {

        float healthPercentage = PlayerHealth.Health / PlayerHealth.HealthMax;

        bar.sizeDelta = new Vector2(173*healthPercentage, 23);



        


    }

    
}
