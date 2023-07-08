using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public GameObject sceneSetter;
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Spikes!!!");
        sceneSetter.GetComponent<SceneSetter>().Spike();
    }
}
