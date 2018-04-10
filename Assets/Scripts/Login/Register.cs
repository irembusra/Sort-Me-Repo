using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour {


    // DatabaseConnection//
    string CreateUserURL = "localhost/UserLogin/Login.php";

    public GameObject go_registerPanel;
    public InputField kullanıcıAdı;
    public InputField sifre;
    public InputField sifreTekrar;
    public string s_kullanıcıAdı;
    public string s_sifre;
    public string s_sifreTekrar;
    public int i_userId;



    private static Register _This;
    public static Register instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<Register>();
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
    public void F_PanelAç()
    {
        go_registerPanel.SetActive(true);
    }
    public void F_onaylama()
    {
        if(s_kullanıcıAdı !=null && s_sifre !=null &&s_sifreTekrar!=null && s_sifre==s_sifreTekrar)
        {
            CreateUser(i_userId,s_kullanıcıAdı, s_sifre);
            go_registerPanel.SetActive(false);
        
        }

    }
    public void F_Kapat()
    {
        go_registerPanel.SetActive(false);
    }
    public void CreateUser(int id,string username,string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("id", id);
        form.AddField("userName", username);
        form.AddField("userPassword", password);

        WWW www = new WWW(CreateUserURL, form);
    }
}
