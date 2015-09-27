using UnityEngine;
using System.Collections;

public class rotateButton : PowerUp {

    private Shooting shooter;

    public override void callPowerUp()
    {
        shooter = GameObject.Find("button").GetComponent<Shooting>();
        shooter.toggleRotate();
    }
}
