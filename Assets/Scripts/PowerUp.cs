using UnityEngine;
using System.Collections;

public abstract class PowerUp : MonoBehaviour {

    private PowerUpSpawner spawner;

    void Start()
    {
        spawner = GameObject.FindObjectOfType<PowerUpSpawner>();
    }

    void OnMouseDown()
    {
        spawner.audio.Play();
        callPowerUp();
        Destroy(gameObject);

    }
    /*
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Contains("bullet"))
        {
            Destroy(gameObject);
            callPowerUp();
        }
        
    }
    */
    public abstract void callPowerUp();
}
