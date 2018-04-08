using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour {
    public Text t_goldText;
    public int i_totalGold;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void F_GoldHesaplama()
    {
        i_totalGold += GameManager.instance.i_level*GameManager.instance.i_levelGold;
        t_goldText.text = "" + i_totalGold;
    }
}
