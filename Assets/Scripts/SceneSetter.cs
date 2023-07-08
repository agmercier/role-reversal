using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSetter : MonoBehaviour
{
    public Transform smileyStart;
    public GameObject playerSmiley;
    public GameObject smileyGoal;

    public Transform frouneyStart;
    public GameObject playerFrouney;
    public GameObject frouneyGoal;

    private int runNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        SceneOne();
    }

    void SceneOne(){
        runNumber = 1;
        playerSmiley.SetActive(true);
        smileyGoal.GetComponent<SmileyGoal>().enabled = true;

        playerFrouney.SetActive(false);
        frouneyGoal.GetComponent<FrouneyGoal>().enabled = false;
    }
    void SceneTwo(){
        runNumber = 2;
        //playerSmiley.transform.position = smileyStart.position;
        playerSmiley.SetActive(true);
        smileyGoal.GetComponent<SmileyGoal>().enabled = true;
        smileyGoal.GetComponent<SmileyGoal>().isRecording = false;
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.transform.position = frouneyStart.position;
        playerFrouney.SetActive(true);
        frouneyGoal.GetComponent<FrouneyGoal>().enabled = true;
    }
    void SceneThree(){
        Debug.Log("Finish!!!");
        playerSmiley.GetComponent<Recorder>().RunIt();
        playerFrouney.GetComponent<Recorder>().RunIt();
    }

    public void SmileyGoalReached(){
        if(runNumber == 1){
            SceneTwo();
        }
        else if(runNumber == 2){
            Debug.Log("resetting to lvl 2");
            SceneTwo();
        }
    }
    public void FrouneyGoalReached(){
        if(runNumber == 1){
            Debug.Log("Error: Frouney goal reached on lvl 1");
        }
        else if(runNumber == 2){
           SceneThree();
        }
    }
}
