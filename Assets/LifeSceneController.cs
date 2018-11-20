using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LifeSceneController : MonoBehaviour {

    public GameObject Image1, Image2, Image3;
    public TextMesh Text1, Text2, Text3;
    public List<Sprite> Gandhi;
    public List<string> Info;

    public GameObject NextButton;
    public GameObject PreviousButton;


    public int index = 0;

	// Use this for initialization
	void Start () {

        PreviousButton.SetActive(false);
        NextButton.SetActive(true);
        index = 0;

        Image1.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index];
        Image2.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index + 1];
        Image3.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index + 2];
    }
	
	// Update is called once per frame
	void Update () {
		
	}



    public void next()
    {
        index = index + 3;
        Image1.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index];
        Image2.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index + 1];
        Image3.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index + 2];

        if(index==0)
        {
            PreviousButton.SetActive(false);
        }
        if(index+3==Gandhi.Count)
        {
            NextButton.SetActive(false);
        }
    }


    public void Previuos()
    {
        index = index - 3;
        Image1.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index];
        Image2.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index + 1];
        Image3.gameObject.GetComponent<SpriteRenderer>().sprite = Gandhi[index + 2];

        if (index == 0)
        {
            PreviousButton.SetActive(false);
        }
        else
        {
            PreviousButton.SetActive(true);
        }
        if (index + 3 == Gandhi.Count)
        {
            NextButton.SetActive(false);
        }
        else
        {
            NextButton.SetActive(true);
        }
    }
}
