using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze : MonoBehaviour
{
    public bool activate;
    public GameObject playerGoomba;
    // Start is called before the first frame update
    void Start()
    {
        activate = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(activate && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.UpArrow))){
            playerGoomba.GetComponent<Recorder>().Freeze();
        }
    }

    public void ResetFreeze(){
        playerGoomba.GetComponent<Recorder>().freezeActive = false;
    }
}
