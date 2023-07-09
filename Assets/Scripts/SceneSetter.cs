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

    public Transform goombaStart;
    public GameObject goomba;

    public GameObject gun;

    public GameObject[] boxes;
    public GameObject[] boxPositions;    

    public int runNumber = 0;
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

        goomba.SetActive(false);
        goomba.transform.position = goombaStart.position;
        goomba.GetComponent<PlayerMovement>().enabled = false;

        for (int i = 0; i < boxes.Length; i++) {
            boxes[i].transform.position = boxPositions[i].transform.position;
        }   

        gun.GetComponent<Gun2>().RemoveAll();
        gun.GetComponent<Gun2>().readInput = false;
        gun.SetActive(false);

        gameObject.GetComponent<freeze>().activate = false;

        // for(int i = 0; i < boxes.Length; i++){
        //     Debug.Log(i);
        //     Transform boxPos = boxPositions[i];
        //     boxes[i].transform.position.x = boxPos.position[0];
        // }
    }

    public void SceneOne(){
        Debug.Log("Scene One Start");
        Reset();
        runNumber = 1;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<PlayerMovement>().enabled = true; 
        playerSmiley.GetComponent<Recorder>().Record();

    }
    public void SceneTwo(){
        Debug.Log("Scene Two Start");
        Reset();
        runNumber = 2;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<PlayerMovement>().enabled = true;
        playerFrouney.GetComponent<Recorder>().Record();
    }
    public void SceneThree(){
        Debug.Log("Scene Three Start");
        Reset();
        runNumber = 3;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<Recorder>().RunIt();

        goomba.SetActive(true);
        goomba.GetComponent<PlayerMovement>().enabled = true;
        goomba.GetComponent<Recorder>().Record();
    }

    public void SceneFour(){
        Debug.Log("Scene Four Start");
        Reset();
        runNumber = 4;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<Recorder>().RunIt();

        goomba.SetActive(true);
        goomba.GetComponent<Recorder>().RunIt();

        //flag to active
        gameObject.GetComponent<freeze>().ResetFreeze();
        StartCoroutine("WaitAndAllowFreeze");
    }

    public void SceneFive(){
        Debug.Log("Scene Five Start");
        Reset();
        runNumber = 5;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<Recorder>().RunIt();

        goomba.SetActive(true);
        goomba.GetComponent<Recorder>().RunIt();

        gun.SetActive(true);
        gun.GetComponent<Gun2>().readInput = true;
    }

    public void SceneSix(){
        Debug.Log("Scene Six Start");
        Reset();
        runNumber = 6;

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<Recorder>().RunIt();

        goomba.SetActive(true);
        goomba.GetComponent<Recorder>().RunIt();
    }

    public void SmileyGoalReached(){
        if(runNumber == 1){
            SceneTwo();
        }
        else if(runNumber == 2){
            SceneTwo();
        }
        else if(runNumber == 3){
            SceneThree();
        }
        else if(runNumber == 4){
            SceneFour();
        }
        else if(runNumber == 5){
            SceneSix();
        }
        else if(runNumber == 6){
            SceneSix();
        }
        else{
            Debug.Log("No scene matches this number");
        }
    }
    public void FrouneyGoalReached(){
        if(runNumber == 1){
            Debug.Log("Error: Frouney goal reached on lvl 1");
        }
        else if(runNumber == 2){
           SceneThree();
        }
        else if(runNumber == 3){
           SceneThree();
        }
        else if(runNumber == 4){
            SceneFive();
        }
        else if(runNumber == 5){
            SceneFive();
        }
        else if(runNumber == 6){
            SceneSix();// not supposed to happen
        }
        else{
            Debug.Log("No scene matches this number");
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
        else if(runNumber == 4){
            SceneFour();
        }
        else if(runNumber == 5){
            SceneFive();
        }
        else{
            Debug.Log("No scene matches this number");
        }
    }

    public IEnumerator WaitAndAllowFreeze(){
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<freeze>().activate = true;
    }
}
