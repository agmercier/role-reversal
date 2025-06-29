using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    private GameObject sceneSetter;

    // Start is called before the first frame update
    void Start()
    {
        sceneSetter = GameObject.Find("EventSystem");
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            int runNumber = sceneSetter.GetComponent<SceneSetter>().runNumber;
            if(runNumber == 3 && other.gameObject.name.Equals("PlayerSmiley")){
                sceneSetter.GetComponent<SceneSetter>().SceneThree();
            }
            else if(runNumber == 3 && other.gameObject.name.Equals("PlayerFrowney")){
                //gameObject.GetComponent<Recorder>().AppendPos(gameObject.transform);
                sceneSetter.GetComponent<SceneSetter>().SceneFour();
                sceneSetter.GetComponent<SceneSetter>().ShowCurrentObjective();
                //put collision position at end of recording
            }
            else if(runNumber == 4 && other.gameObject.name.Equals("PlayerFrowney")){
                sceneSetter.GetComponent<SceneSetter>().SceneFour();
            }
            else if(runNumber == 5 && other.gameObject.name.Equals("PlayerFrowney")){
                sceneSetter.GetComponent<SceneSetter>().SceneFive();
            }
            else if(runNumber == 6 && other.gameObject.name.Equals("PlayerFrowney")){
                sceneSetter.GetComponent<SceneSetter>().SceneSix();
            }
            else if(runNumber == 7 && other.gameObject.name.Equals("PlayerFrowney")){
                sceneSetter.GetComponent<SceneSetter>().SceneSeven();
            }
        }
    }

}
