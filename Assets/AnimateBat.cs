using UnityEngine;
using System.Collections;

public class AnimateBat : MonoBehaviour {

    public Sprite spriteAnim;

    SpriteRenderer sprite;

	// Use this for initialization
	void Start () {
        sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Contains("bullet"))
        {
            sprite.sprite = spriteAnim;
            StartCoroutine(Wait());
        }
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

}
