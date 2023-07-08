using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrouneyGoal : MonoBehaviour
{
    public GameObject sceneSetter;
    public GameObject playerFrouney;
    public bool isRecording = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other){
         if (playerFrouney != null)
        {
            Debug.Log("Frouney Goal!!!");
            //playerFrouney.GetComponent<Recorder>().RunIt();
            sceneSetter.GetComponent<SceneSetter>().FrouneyGoalReached();
        }
    }
}
