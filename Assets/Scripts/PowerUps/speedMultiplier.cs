using UnityEngine;
using System.Collections;

public class speedMultiplier : PowerUp {

    public float speed;

    public override void callPowerUp()
    {
        RotateRing ring = GameObject.Find("ring").GetComponent<RotateRing>();
        ring.SpeedUp(speed);
    }
}
