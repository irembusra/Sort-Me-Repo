using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour {
    private static Event _This;

    public static Event instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<Event>();
            }

            return _This;
        }
    }
    public int Date;
  
   


	// Use this for initialization
	void Start () {
      
  
     
    }
	
	// Update is called once per frame
	void Update () {

       
    }


   
}
