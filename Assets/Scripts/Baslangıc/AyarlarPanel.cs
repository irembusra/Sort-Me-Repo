using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AyarlarPanel : MonoBehaviour {
    public GameObject go_AyarlarPanel;
	// Use this for initialization
	void Start () {
        go_AyarlarPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void F_ayarlarPanelAç()
    {
        go_AyarlarPanel.SetActive(true);

    }
    public void F_ayarlarPanelKapat()
    {
        go_AyarlarPanel.SetActive(false);

    }
}
