using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Durdur : MonoBehaviour {
    public GameObject go_DurdurBigPanel;
    public GameObject go_DurdurSmallPanel;
    public GameObject go_DurdurButton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void F_DurdurButton()
    {
        go_DurdurBigPanel.SetActive(true);
        go_DurdurSmallPanel.SetActive(true);
        GameManager.instance.timeRunning = false;
      //  go_DurdurButton.SetActive(false);

    }
    public void F_BaşlatButton()
    {
        go_DurdurBigPanel.SetActive(false);
        go_DurdurSmallPanel.SetActive(false);
        GameManager.instance.timeRunning = true;
      //  go_DurdurButton.SetActive(true);

    }
}
