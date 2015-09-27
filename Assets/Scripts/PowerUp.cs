using UnityEngine;
using System.Collections;

public abstract class PowerUp : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Contains("bullet"))
        {
            Destroy(gameObject);
            callPowerUp();
        }
        
    }

    public abstract void callPowerUp();
}
