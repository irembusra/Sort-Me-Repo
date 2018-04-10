using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGamePanel : MonoBehaviour {
    public Image endGamePanel;
    public Animator endGamePanelAnim;
    Button playAgain;
    Button mainMenu;
    Text endGameText;
    public Text T_PanelPuan;
    public Text T_PanelGold;
    public GameObject go_playagain;
    public GameObject go_nextLevel;

    private static EndGamePanel _This;

    public static EndGamePanel instance
    {
        get
        {
            if (_This == null)
            {
                _This = GameObject.FindObjectOfType<EndGamePanel>();
            }

            return _This;
        }
    }
    // Use this for initialization
    void Start () {
        playAgain = endGamePanel.GetComponentsInChildren<Button>()[0];
        mainMenu = endGamePanel.GetComponentsInChildren<Button>()[1];
        endGameText = endGamePanel.transform.Find("endGameText").GetComponent<Text>();
        go_nextLevel.SetActive(false);
        go_playagain.SetActive(false);
        endGamePanelAnim = endGamePanel.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void F_WinPanelOpen()
    {
        endGamePanel.gameObject.SetActive(true);
        endGamePanelAnim.SetTrigger("endGame");
        endGameText.text = "  TEBRIKLER";
        T_PanelPuan.text =GameManager.instance.remainingTimeInSeconds.ToString(); 
        T_PanelGold.text = "" + GameManager.instance.i_levelGold;
        go_nextLevel.SetActive(true);

    }
    public void F_LosePanelOpen()
    {
        endGamePanel.gameObject.SetActive(true);
        endGamePanelAnim.SetTrigger("endGame");
        endGameText.text = " UZGUNUZ";
        T_PanelPuan.text = "0";
        T_PanelGold.text = "0";
        go_playagain.SetActive(true);
    }
}
