using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

    public GameObject button;

    public GameObject title, tut1, tut2, panel;

    private GameObject currentActive;

	// Use this for initialization
	void Start () {

        currentActive = title;

	}
	
	// Update is called once per frame
	void Update () {
        if (button.activeInHierarchy)
        {
            button.transform.Rotate(Vector3.forward * 1);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click");
            click();
        }

    }

    void click()
    {
        Debug.Log(currentActive.name);
        switch (currentActive.name)
        {
            case "Title":
                title.SetActive(false);
                panel.SetActive(true);
                tut1.SetActive(true);
                currentActive = tut1;
                break;
            case "tut1":
                tut1.SetActive(false);
                tut2.SetActive(true);
                currentActive = tut2;
                break;
            case "tut2":
                Application.LoadLevel("MainScreen");
                break;
        }



    }

}
