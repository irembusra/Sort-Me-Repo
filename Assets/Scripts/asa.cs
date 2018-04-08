using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asa : MonoBehaviour {
    public int ida;
    public string olaya;
    public int yeara;

    string CreateeventURL = "localhost/Deneme/Deneme.php";
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
            Createevent(ida, olaya, yeara);
            Debug.Log("asas");
        
	}
    public void Createevent(int id,string olay,int year)
    {  
        WWWForm form = new WWWForm();
        form.AddField("idpost",id);
        form.AddField("event", olay);
        form.AddField("year", year);
        Debug.Log("aaa");

        WWW www = new WWW(CreateeventURL, form);

    }
}
