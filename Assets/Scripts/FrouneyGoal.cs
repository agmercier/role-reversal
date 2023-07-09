using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrouneyGoal : MonoBehaviour
{
    public GameObject sceneSetter;
    public GameObject playerFrouney;

    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other){
         if (playerFrouney != null)
        {
            if(other.gameObject.name.Equals("PlayerFrowney")){
                sceneSetter.GetComponent<SceneSetter>().FrouneyGoalReached();
            }
        }
    }
}
