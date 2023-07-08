using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmileyGoal : MonoBehaviour
{
    public GameObject sceneSetter;
    public GameObject playerSmiley;
    public bool isRecording = true;

    // Start is called before the first frame update
    void Start()
    {
        if(isRecording){
            playerSmiley.GetComponent<Recorder>().Record();
            isRecording = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
         if (playerSmiley != null)
        {
            Debug.Log("Smiley Goal!!!");
            //playerSmiley.GetComponent<Recorder>().RunIt();
            sceneSetter.GetComponent<SceneSetter>().SmileyGoalReached();
        }
    }
}
