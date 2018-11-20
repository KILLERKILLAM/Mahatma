using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public GameObject IntroScene;
    public GameObject LifeScene;
    public GameObject Monuments;


    public GameObject IntroPanel;
    public GameObject LifePanel;
    public GameObject MonumentPanel;

	// Use this for initialization
	void Start () {
        IntroScene.gameObject.SetActive(true);
        LifeScene.gameObject.SetActive(false);
        Monuments.gameObject.SetActive(false);


        IntroPanel.gameObject.SetActive(true);
        LifePanel.gameObject.SetActive(false);
        MonumentPanel.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ActiveIntro()
    {
        IntroScene.gameObject.SetActive(true);
        LifeScene.gameObject.SetActive(false);
        Monuments.gameObject.SetActive(false);



        IntroPanel.gameObject.SetActive(true); 
        LifePanel.gameObject.SetActive(false); 
        MonumentPanel.gameObject.SetActive(false); 
    }

    public void ActiveLife()
    {
        IntroScene.gameObject.SetActive(false);
        LifeScene.gameObject.SetActive(true);
        Monuments.gameObject.SetActive(false);

        IntroPanel.gameObject.SetActive(false);
        LifePanel.gameObject.SetActive(true);
        MonumentPanel.gameObject.SetActive(false);
    }

    public void MonumentScene()
    {
        IntroScene.gameObject.SetActive(false);
        LifeScene.gameObject.SetActive(false);
        Monuments.gameObject.SetActive(true);

        IntroPanel.gameObject.SetActive(false);
        LifePanel.gameObject.SetActive(false);
        MonumentPanel.gameObject.SetActive(true);
    }

}
