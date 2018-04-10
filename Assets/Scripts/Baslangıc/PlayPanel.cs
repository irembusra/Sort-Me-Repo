using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayPanel : MonoBehaviour {
    private static bool created = false;
    public bool b_tarih=false; // tarih butonu için
    public bool b_math = false; // Math butonu için
    public bool b_doubleTime = false; // süreyi iki katına çıkarırken buton durumu
    public bool b_doubleGold = false;
    public GameObject go_timeJoker;
    public GameObject go_goldJoker;
    public GameObject go_math;
    public GameObject go_tarih;
    public GameObject go_playGameButton;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }
    private static PlayPanel _This;

    public static PlayPanel instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType< PlayPanel  >();
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
    public void F_PlayPanelKapat()
    {
      //  UIScripts.instance.go_playPanel.SetActive(false);
    }
    public void F_TarihKategori()
    {
        b_tarih=!b_tarih;
        go_tarih.transform.GetChild(1).gameObject.SetActive(!go_tarih.transform.GetChild(1).gameObject.activeInHierarchy);
        go_playGameButton.SetActive(true);
        if (b_math==true)
        {
            go_math.transform.GetChild(1).gameObject.SetActive(false);
            b_math = false;
        }
    }
    public void F_MathKategori()
    {
        b_math = !b_math;
        go_math.transform.GetChild(1).gameObject.SetActive(!go_math.transform.GetChild(1).gameObject.activeInHierarchy);
        go_playGameButton.SetActive(true);
       if(b_tarih==true)
        {
            go_tarih.transform.GetChild(1).gameObject.SetActive(false);
            b_tarih = false;
        }
    }
    public void F_IkiKatıGoldJoker()
    {
        b_doubleGold = !b_doubleGold;
        go_goldJoker.transform.GetChild(1).gameObject.SetActive(!go_goldJoker.transform.GetChild(1).gameObject.activeInHierarchy);

    }
    public void F_DoubleTime()
    {
        b_doubleTime = !b_doubleTime;
        go_timeJoker.transform.GetChild(1).gameObject.SetActive(!go_timeJoker.transform.GetChild(1).gameObject.activeInHierarchy);
    }
    public void F_PlayGame()
    {
        SceneManager.LoadScene("gameScene");

    }
}
