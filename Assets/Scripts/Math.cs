using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Math : MonoBehaviour {
    private static Math _This;

    public static Math instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<Math>();
            }

            return _This;
        }
    }
    public int i_firstNumber;
    public int i_secondNumber;
    public int[] a_questionArray;
    public string[] a_questionOperation;
    public int x; // for döngüleri
    
    public int[] i_solution;
   
    // Use this for initialization
    void Start () {
      
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    public void F_MathQuestion()
    {
        
        

        int i_questionOperation;


        
        for(int i=x; i<7; i++)
        {
            x++;
           // Debug.Log(i);
            i_firstNumber = Random.Range(1, 10);
            i_secondNumber = Random.Range(1, 10);
            i_questionOperation = Random.Range(0, 2);
            
           // i_questionOperation = 0;
            if (i == 1)
            {
                //Debug.Log("girdi");
            }
            
            if (i_questionOperation == 0)
            {
                GameManager.instance.Event[i].GetComponentInChildren<Text>().text = i_firstNumber + "+"+ i_secondNumber;
                i_solution[i] = i_firstNumber + i_secondNumber;
            }
            else if(i_questionOperation == 1)
            {
                GameManager.instance.Event[i].GetComponentInChildren<Text>().text = i_firstNumber + "*" + i_secondNumber;
                i_solution[i] = i_firstNumber * i_secondNumber;
            }
             else if (i_questionOperation == 2)
               {
                   GameManager.instance.Event[i].GetComponentInChildren<Text>().text = i_firstNumber + "-" + i_secondNumber;
                   i_solution[i] = i_firstNumber - i_secondNumber;
               }
             /*  else
               {
                   GameManager.instance.Event[i].GetComponentInChildren<Text>().text = i_firstNumber + "/" + i_secondNumber;
                   i_solution[i] = i_firstNumber /i_secondNumber;
               }*/
            GameManager.instance.Event[i].GetComponent<Event>().Date=i_solution[i];
            Debug.Log(i+"th " + i_solution[i]);
        }
       
        
        
    }

   
}
