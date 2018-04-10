using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ÜyeGirişi : MonoBehaviour {
    public GameObject go_UyeGirisiPanel;
    public InputField KullanıcıAdı;
    public InputField Sifre;
    public string s_KullanıcıAdı;
    public string s_sifre;


    // Use this for initialization
    void Start () {
        go_UyeGirisiPanel.SetActive(false);
        s_KullanıcıAdı = "irem";
        s_sifre = "gülfem";
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void F_UyeGirisiAç()
    {
        go_UyeGirisiPanel.SetActive(true);

    }
    public void OyunGiris()
    {
        if(KullanıcıAdı.text==s_KullanıcıAdı && Sifre.text==s_sifre)
        {
            SceneManager.LoadScene("GirisScene");

        }

    }
    public void F_Kapat()
    {
        go_UyeGirisiPanel.SetActive(false); 
    }
}
