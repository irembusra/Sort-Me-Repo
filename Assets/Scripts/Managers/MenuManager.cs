using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    public GameObject go_categoryPanel;
	// Use this for initialization
	void Start () {
        go_categoryPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void F_SelectCategory()
    {

        go_categoryPanel.SetActive(true);
    }

    public void StartHistoryGame()
    {
        //Dummy Code
        SceneManager.LoadScene("gameScene");
    }
}
