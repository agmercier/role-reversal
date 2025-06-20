using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Vector3 frouneyGoalPosition;

    public GameObject otherEventSystem;

    public int runNumber = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        SceneOne();
    }
    void Update(){
        if(Input.GetKeyUp(KeyCode.R)){
           runNumber = runNumber - 1;
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
        

        frouneyGoal.transform.position = frouneyGoalPosition;
        frouneyGoal.GetComponent<PlayerMovement>().enabled = false;

        otherEventSystem.GetComponent<PauseScreenScript>().UpdatePanel(runNumber);

    }   

    //Smiley gets to goal
    public void SceneOne(){
        Debug.Log("Scene One Start");
        runNumber = 1;
        Reset();

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<PlayerMovement>().enabled = true; 
        playerSmiley.GetComponent<Recorder>().Record();

    }

    //Frowney gets to goal
    public void SceneTwo(){
        Debug.Log("Scene Two Start");
        runNumber = 2;
        Reset();

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<PlayerMovement>().enabled = true;
        playerFrouney.GetComponent<Recorder>().Record();
    }

    //Goomba
    public void SceneThree(){
        Debug.Log("Scene Three Start");
        runNumber = 3;
        Reset();

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<Recorder>().RunIt();

        goomba.SetActive(true);
        goomba.GetComponent<PlayerMovement>().enabled = true;
        goomba.GetComponent<Recorder>().Record();
    }

    //freeze
    public void SceneFour(){
        Debug.Log("Scene Four Start");
        runNumber = 4;
        Reset();

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

    //Gun
    public void SceneFive(){
        Debug.Log("Scene Five Start");
        runNumber = 5;
        Reset();

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<Recorder>().RunIt();

        goomba.SetActive(true);
        goomba.GetComponent<Recorder>().RunIt();

        gun.SetActive(true);
        gun.GetComponent<RecordGun>().Record();
        gun.GetComponent<Gun2>().readInput = true;
    }

    public void SceneSix(){
        Debug.Log("Scene Six Start");
        runNumber = 6;
        Reset();

        playerSmiley.SetActive(true);
        playerSmiley.GetComponent<Recorder>().RunIt();

        playerFrouney.SetActive(true);
        playerFrouney.GetComponent<Recorder>().RunIt();

        goomba.SetActive(true);
        goomba.GetComponent<Recorder>().RunIt();

        gun.SetActive(true);
        gun.GetComponent<RecordGun>().RunIt();

        frouneyGoal.GetComponent<PlayerMovement>().enabled = true;
        frouneyGoal.GetComponent<Recorder>().Record();
    }

    public void SceneSeven(){
        Debug.Log("Scene Seven Start");
        runNumber = 7;
        Reset();

        // playerSmiley.SetActive(true);
        // playerSmiley.GetComponent<Recorder>().RunIt();

        // playerFrouney.SetActive(true);
        // playerFrouney.GetComponent<Recorder>().RunIt();

        // goomba.SetActive(true);
        // goomba.GetComponent<Recorder>().RunIt();

        // gun.SetActive(true);
        // gun.GetComponent<RecordGun>().RunIt();

        // frouneyGoal.GetComponent<Recorder>().RunIt();
        SceneManager.LoadScene(2);
    }

    public void SmileyGoalReached(){
        if(runNumber == 1){
            SceneTwo();
            otherEventSystem.GetComponent<PauseScreenScript>().ShowCurrentObjective();
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
            otherEventSystem.GetComponent<PauseScreenScript>().ShowCurrentObjective();
        }
        else if(runNumber == 6){
            SceneSix();
        }
        else if(runNumber == 7){
            SceneSeven();
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
           otherEventSystem.GetComponent<PauseScreenScript>().ShowCurrentObjective();
        }
        else if(runNumber == 3){
           SceneThree();
        }
        else if(runNumber == 4){
            SceneFive();
            otherEventSystem.GetComponent<PauseScreenScript>().ShowCurrentObjective();
        }
        else if(runNumber == 5){
            SceneFive();
        }
        else if(runNumber == 6){
            SceneSeven();
            otherEventSystem.GetComponent<PauseScreenScript>().ShowCurrentObjective();
        }
        else if(runNumber == 7){
            SceneSeven();
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
        else if(runNumber == 6){
            SceneSix();
        }
        else if(runNumber == 7){
            SceneSeven();
        }
        else{
            Debug.Log("No scene matches this number");
        }
    }

    public IEnumerator WaitAndAllowFreeze(){
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<freeze>().activate = true;
    }
    public void ShowCurrentObjective(){
        otherEventSystem.GetComponent<PauseScreenScript>().ShowCurrentObjective();
    }
}
