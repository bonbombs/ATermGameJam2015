using UnityEngine;
using System.Collections;
using System;

public class AddBones : PowerUp {

    private Shooting shooter; 

    public override void callPowerUp()
    {
        shooter = GameObject.Find("button").GetComponent<Shooting>();
        if(shooter.bulletNum + 1 < shooter.maxBullets)
        {
            shooter.bulletNum++;
        }

    }
}
