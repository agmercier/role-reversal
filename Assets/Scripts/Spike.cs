using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private GameObject sceneSetter;

    void Start(){
        sceneSetter = GameObject.Find("EventSystem");
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            int runNumber = sceneSetter.GetComponent<SceneSetter>().runNumber;
            if(runNumber == 1 && other.gameObject.name.Equals("PlayerSmiley")){
                sceneSetter.GetComponent<SceneSetter>().SceneOne();
            }
            else if(runNumber == 2 && other.gameObject.name.Equals("PlayerFrowney")){
                sceneSetter.GetComponent<SceneSetter>().SceneTwo();
            }
            else if(runNumber == 3 && other.gameObject.name.Equals("PlayerGoomba")){
                sceneSetter.GetComponent<SceneSetter>().SceneThree();
            }
            else if(runNumber == 4 && other.gameObject.name.Equals("PlayerGoomba")){
                sceneSetter.GetComponent<SceneSetter>().SceneFour();
            }
            else if(runNumber == 5 && other.gameObject.name.Equals("PlayerFrowney")){
                GameObject.Find("PlayerFrowney").SetActive(false);
            }
            else if(runNumber == 5 && other.gameObject.name.Equals("PlayerGoomba")){
                sceneSetter.GetComponent<SceneSetter>().SceneFive();
            }
            else if(runNumber == 5 && other.gameObject.name.Equals("PlayerSmiley")){
                sceneSetter.GetComponent<SceneSetter>().SceneFive();
            }
        }
        
    }
}
