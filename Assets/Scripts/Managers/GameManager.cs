using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public GameObject go_EndpanelText;


        private static GameManager _This;

        public static GameManager instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<GameManager>();
            }

            return _This;
        }
    }
    public GameObject[] Event = new GameObject[7];
   
    public GameObject[] orderedEvent = new GameObject[7];

    public int remainingTimeInSeconds;


    public bool Spawn;
    public int Count = 0;
    
    public static int answerCount = 0;    //To avoid checking with empty spots
    public int i_level;
    public int i_levelGold;
    // süre//
    
    float remainingTime;
    public bool timeRunning=true;
    public Text remainingTimeText;
    private float remainingTimeToAnswer;

    // end Panel//

    public int x;
     //kategori seçimi//
    public GameObject go_Tarih;
    public GameObject go_Math;
    public bool b_databaseconnection=false;
    public bool b_mathconnection = false;
    

 
	
	void Start () {

      

        Spawn = true;

      

        answerCount = 0;
        // Kategori Türü//
        
       if(PlayPanel.instance.b_math==true)
        {
            go_Math.SetActive(true);
            b_mathconnection = true;
        }
        else if(PlayPanel.instance.b_tarih==true)
        {

            go_Tarih.SetActive(true);
            b_databaseconnection = true;
        }

        // Double Time Joker//

        if (PlayPanel.instance.b_doubleTime == true)
        {
            remainingTimeToAnswer = 120f;
            // timeToAnswer = 120f;
            Debug.Log("Time");
        }
        else
            remainingTimeToAnswer = 60f;
        //timeToAnswer = 60f;
        //Little bug without this
        ResetTimer();
        //Debug.Log(endGameText.name);

        // Double Gold Joker//
        if (PlayPanel.instance.b_doubleGold == true)
        { i_levelGold = 20; }
        else
            i_levelGold = 10;

    }
	
	
	void Update () {

        //not yet randomized
        
        if(Spawn && Count < 7 )
        {
            //Debug.Log("trying to spawn");
            Event[Count].SetActive(true);
            Count++;
            Spawn = false;
            if (b_mathconnection==true)
            {
                Math.instance.F_MathQuestion();
            }
            
              
        }

       

        if(timeRunning)
        {
            remainingTime = remainingTime - Time.deltaTime;
        }


        if(remainingTime>0)
        {
            remainingTimeInSeconds = Mathf.FloorToInt(remainingTime) + 1;
            remainingTimeText.text =  remainingTimeInSeconds.ToString();
        }
        

      /*  if(remainingTime<=0)
        {
            remainingTimeText.text = "Time Remaining : 0";
            endGamePanel.gameObject.SetActive(true);
            endGameText.text = "You're out of time";
            
        }*/

        //Debug.Log(Spawn);


    }

    public void CheckAnswers()
    {

       
            //bool b_Wrong = false;
           int Wrong = 0;
           // Debug.Log(answerCount);

            //going to add checks...

            for (int i = 0; i < 6; i++)
            {
               // Debug.Log(b_Wrong);
                if(orderedEvent[i] != null && orderedEvent[i+1] != null)
                {
                    Debug.Log(orderedEvent[i].GetComponent<Event>().Date);
                    //orderedEvent[i] = Event[i];
                    if (orderedEvent[i].GetComponent<Event>().Date > orderedEvent[i + 1].GetComponent<Event>().Date)
                    {
                       
                      //  Debug.Log("sfds");
                       Wrong++;
                    Debug.Log("wrongis " + orderedEvent[i].GetComponent<Event>().Date);
                     //   b_Wrong = true;
                    }
                    /*else if(orderedEvent[i].GetComponent<Event>().Date ==orderedEvent[i + 1].GetComponent<Event>().Date)
                    {

                        b_Wrong = false;
                    }*/
                    
                    

                    
                }
                
            }
        Debug.Log("wrongcount " + Wrong);

            if (Wrong == 0 && Count == 7 )
            {
                 Debug.Log("Answer Correct " + Wrong);

                timeRunning = false;
            EndGamePanel.instance.F_WinPanelOpen();
            go_EndpanelText.transform.GetChild(0).gameObject.SetActive(true);
              
                i_level++;
           
            
                Puan.instance.i_levelPuan = Mathf.FloorToInt(remainingTime) + 1;
               // Puan.instance.F_PuanHesaplama();
            
            


        }
            else if (Wrong > 0 && Count == 7 )
            {
                timeRunning = false;
            EndGamePanel.instance.F_LosePanelOpen();
            //     Debug.Log("Answer False " + Wrong);

            go_EndpanelText.transform.GetChild(1).gameObject.SetActive(true);
          
                Puan.instance.i_levelPuan = 0;
            i_level = 0;
            }

          //  else

               // Debug.Log("Answer incomplete");
        

    }
   
    void ResetTimer()
    {
        remainingTime =remainingTimeToAnswer;
        timeRunning = true;
        Debug.Log("resetTimer");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(1);  //Game Scene index is 1
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);  //Main Scene index is 0
    }
}
