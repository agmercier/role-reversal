using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject sceneSetter;
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            sceneSetter.GetComponent<SceneSetter>().Spike();
        }
        
    }
}
