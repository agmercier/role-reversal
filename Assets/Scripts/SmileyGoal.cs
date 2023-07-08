using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmileyGoal : MonoBehaviour
{
    public GameObject sceneSetter;
    public GameObject playerSmiley;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other){
         if (playerSmiley != null)
        {
            if(other.gameObject.name.Equals("PlayerSmiley")){
                Debug.Log("Smiley Goal!!!");
                sceneSetter.GetComponent<SceneSetter>().SmileyGoalReached();
            }
            
        }
    }
}   
