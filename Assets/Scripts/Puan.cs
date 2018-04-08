using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour {
    public Text t_totalPuan;
    public int i_totalPuan;
    public int i_levelPuan;

    private static Puan _This;

    public static Puan instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<Puan>();
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
    public void F_PuanHesaplama()
    {
        i_totalPuan += i_levelPuan;
        t_totalPuan.text ="" + i_totalPuan;

    }
}
