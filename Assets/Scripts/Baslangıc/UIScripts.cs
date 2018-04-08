using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour {
    public Text t_gold;
    public Text t_puan;
    public GameObject go_playPanel;
    private static UIScripts _This;

    public static UIScripts instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<UIScripts>();
            }

            return _This;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void F_Play1()
    {
        go_playPanel.SetActive(true);
    }
}
