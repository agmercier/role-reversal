using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject sceneSetter;
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            int runNumber = sceneSetter.GetComponent<SceneSetter>().runNumber;
            if(runNumber == 1 && other.gameObject.name.Equals("PlayerSmiley")){
                sceneSetter.GetComponent<SceneSetter>().SceneOne();
            }
            else if(runNumber == 2 && other.gameObject.name.Equals("PlayerFrowney")){
                sceneSetter.GetComponent<SceneSetter>().SceneTwo();
            }
            else if(runNumber == 3 && other.gameObject.name.Equals("Goomba")){
                sceneSetter.GetComponent<SceneSetter>().SceneThree();
            }
        }
        
    }
}
