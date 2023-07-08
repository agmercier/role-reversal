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

    public GameObject[] boxes;
    public GameObject[] boxPositions;    

    private int runNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        // boxPositions = new Transform[5];
        // for(int i = 0; i < boxes.Length; i++){
        //     boxPositions[i] = boxes[i].transform;
        // }
        SceneOne();
    }
    void Update(){
        if(Input.GetKeyUp(KeyCode.R)){
           runNumber = runNumber - 1;
           Debug.Log(runNumber);
           if(runNumber < 1){
            runNumber = 1;
           }
           Spike();
        }
    }

    void Reset(){
        playerSmiley.SetActive(false);
        playerSmiley.transform.position = smileyStart.position;
        playerSmiley.GetComponent<PlayerMovement>().enabled = false; 

        playerFrouney.SetActive(false);
        playerFrouney.transform.position = frouneyStart.position;
        playerFrouney.GetComponent<PlayerMovement>().enabled = false;

        for (int i = 0; i < boxes.Length; i++) {
            boxes[i].transform.position = boxPositions[i].transform.position;
        }

        // for(int i = 0; i < boxes.Length; i++){
        //     Debug.Log(i);
        //     Transform boxPos = boxPositions[i];
        //     boxes[i].transform.position.x = boxPos.position[0];
        // }
    }

    void SceneOne(){
        Debug.Log("Scene One Start");
        Reset();
        runNumber = 1;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<PlayerMovement>().enabled = true; 
        playerSmiley.GetComponent<Recorder>().Record();

    }
    void SceneTwo(){
        Debug.Log("Scene Two Start");
        Reset();
        runNumber = 2;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<PlayerMovement>().enabled = true;
        playerFrouney.GetComponent<Recorder>().Record();
    }
    void SceneThree(){
        Debug.Log("Scene Three Start");
        Reset();
        runNumber = 3;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
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
    public void Spike(){
        if(runNumber == 1){
            SceneOne();
        }
        else if(runNumber == 2){
            SceneTwo();
        }
        else if(runNumber == 3){
            SceneThree();
        }
    }
}
