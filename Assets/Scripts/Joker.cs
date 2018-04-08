using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Joker : MonoBehaviour {
    public GameObject go_jokerButton;
   public GameObject go_jokerPanel;
    public Text t_jokerText;
    public Text t_jokerYıl;

	// Use this for initialization
	void Start () {
        go_jokerButton.SetActive(false);
        go_jokerPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.instance.Count == 7)
        {

            go_jokerButton.SetActive(true);
        }
    }

    public void F_JokerButton()
    {
        F_Show();

    }

    public void F_Show()
    {
       go_jokerPanel.SetActive(true);
        // t_jokerText.text = DataBaseConnection.instance.olay;
        //t_jokerYıl.text = DataBaseConnection.instance.s_jokerYear;

    }

    public void F_JokerKapat()
    {
        go_jokerPanel.SetActive(false);
        
    }
}
