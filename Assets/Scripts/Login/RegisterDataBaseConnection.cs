using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterDataBaseConnection : MonoBehaviour {
    public InputField userName;
    public InputField userPassword;
    public InputField userAgainPassword;
    
    string CreateUserURL = "http://up-techlabs.com/SortMe/SortMeUser.php";
    // Use this for initialization
    int x;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


	}
    public void Createuser(string s_username,string s_password)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", s_username);
        form.AddField("password", s_password);

        WWW www = new WWW(CreateUserURL, form);

    }

    public void RegisterButton()
    {
        if(userName.text!=""&& userPassword.text!="" && userPassword.text==userAgainPassword.text)
        {
            Createuser(userName.text, userPassword.text);
        }

        else if(userPassword.text != userAgainPassword.text)
        {
            Debug.Log("şifre tutarsız");
        }
    }
}
