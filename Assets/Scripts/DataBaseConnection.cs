using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBaseConnection : MonoBehaviour {

    // Use this for initialization
   private static DataBaseConnection _This;

    public static DataBaseConnection instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<DataBaseConnection>();
            }

            return _This;
        }
    }



    public string[] items;
    public int year;
    public string olay;
    public string s_jokerYear;

    IEnumerator Start()
    {
        if (GameManager.instance.b_databaseconnection==true)
        {
            WWW itemsData = new WWW("http://localhost/Sortme/SortMeData.php");

            yield return itemsData;
            string itemsDataString = itemsData.text;
            print(itemsDataString);
            items = itemsDataString.Split(';');

            for (int i = 0; i < 7; i++)
            {
                print(GetDataValue(items[i], "event:"));
                GameManager.instance.Event[i].GetComponentInChildren<Text>().text = GetDataValue(items[i], "event:");
                olay = GetDataValue(items[0], "event:");
            }
            for (int i = 0; i < 7; i++)
            {

                GameManager.instance.Event[i].GetComponent<Event>().Date = int.Parse(GetDataValue(items[i], "year:"));
                year = int.Parse(GetDataValue(items[i], "year:"));
                s_jokerYear = GetDataValue(items[0], "year:");
                Debug.Log(GetDataValue(items[i], "year:"));


            }


        }
    }


        string GetDataValue(string data, string index)

        {
            // print(data);
            string value = data.Substring(data.IndexOf(index) + index.Length);
            if (value.Contains("|")) value = value.Remove(value.IndexOf("|"));
            return value;
        }
    
    
}


























//void Start(){
//	string data = "ID:1|Name:Health Potion|Type:consumables|Cost:50";
//	print(GetDataValue(data, "Cost:"));
//}
//
//void Update(){
//	
//}
//
//string GetDataValue(string data ,string index){
//	string value = data.Substring(data.IndexOf(index)+index.Length);
//	if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
//	return value;
//}

