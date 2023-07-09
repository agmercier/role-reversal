using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreenScript : MonoBehaviour
{
    public GameObject objpanel1;
    public GameObject objpanel2;
    public GameObject objpanel3;
    public GameObject objpanel4;
    public GameObject objpanel5;
    public GameObject objpanel6;
    public GameObject objpanel7;

    public GameObject creditPanel1;
    public GameObject creditPanel2;
    public GameObject creditPanel3;
    public GameObject controlPanel;

    private bool menuUp;

    private GameObject objpanel;

    private void Start()
    {
        objpanel = objpanel1;
        menuUp = false;
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    void Update (){
        if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("sescapefneininininini");
            if(!menuUp){
                menuUp = true;
                goControl();
            }
            else{
                 menuUp = false;
                goGame();
            }
        }
    }

    public void goMainPanel(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    public void goStart()
    {
        SceneManager.LoadScene(0);
    }

     public void goControl()
    {
        controlPanel.SetActive(true);
        objpanel.SetActive(false);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    public void goCredit1()
    {
        controlPanel.SetActive(false);
        objpanel.SetActive(false);
        creditPanel1.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    public void goCredit2()
    {
        controlPanel.SetActive(false);
        objpanel.SetActive(false);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(true);
        creditPanel3.SetActive(false);
    }

    public void goCredit3()
    {
        controlPanel.SetActive(false);
        objpanel.SetActive(false);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(true);
    }

    public void exitGame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    public void goGame()
    {
        controlPanel.SetActive(false);
        objpanel.SetActive(false);
        creditPanel1.SetActive(false);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    // -------------
    public void ShowObjectiveOne(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }
    public void ShowObjectiveTwo(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }
    public void ShowObjectiveThree(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }
    public void ShowObjectiveFour(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }
    public void ShowObjectiveFive(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }
    public void ShowObjectiveSix(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }
    public void ShowObjectiveSeven(){
        controlPanel.SetActive(false);
        creditPanel1.SetActive(false);
        objpanel.SetActive(true);
        creditPanel2.SetActive(false);
        creditPanel3.SetActive(false);
    }

    public void UpdatePanel(int runNumber){
         if(runNumber == 1){
            objpanel = objpanel1;
        }
        else if(runNumber == 2){
            objpanel = objpanel2;
        }
        else if(runNumber == 3){
            objpanel = objpanel3;
        }
        else if(runNumber == 4){
            objpanel = objpanel4;
        }
        else if(runNumber == 5){
            objpanel = objpanel5;
        }
        else if(runNumber == 6){
           objpanel = objpanel6;
        }
        else if(runNumber == 7){
            objpanel = objpanel7;
        }
        else{
            Debug.Log("No scene matches this number");
        }
    }
}