using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {
    private static EndGame _This;

    public static EndGame instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<EndGame>();
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
    public void EndGameCorrectAnswer()
    {
       // for(int i=0; i<7; i++)
        {
            // GameManager.instance.orderedEvent[2].GetComponentInChildren<Text>().text = DataBaseConnection.instance.GetDataValue(DataBaseConnection.instance.items[2], "event:")+""+ DataBaseConnection.instance.GetDataValue(DataBaseConnection.instance.items[2], "year:");
            Debug.Log("birinci text" + GameManager.instance.orderedEvent[2].GetComponentInChildren<Text>().text);
            Debug.Log("event" +DataBaseConnection.instance.eventarray[2]);
            Debug.Log("year"+ DataBaseConnection.instance.GetDataValue(DataBaseConnection.instance.items[2], "year:"));

        }

    }
}
