using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Görevler : MonoBehaviour {
    public GameObject go_GorevlerPanel;
    public GameObject go_GorevlerPanelKapat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void F_gorevlerAc()
    {

        go_GorevlerPanel.SetActive(true);
    }
    public void F_gorevlerKapat()
    {

        go_GorevlerPanel.SetActive(false);
    }
}
