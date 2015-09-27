using UnityEngine;
using System.Collections;

[System.Serializable]
public class ReverseDirection : PowerUp
{
    public override void callPowerUp()
    {
        RotateRing ring = GameObject.Find("ring").GetComponent<RotateRing>();
        if(ring.direction == "cw")
        {
            ring.ChangeDirection("ccw");
        } else
        {
            ring.ChangeDirection("cw");
        }
    }
}