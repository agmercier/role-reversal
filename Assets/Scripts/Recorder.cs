using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Recorder : MonoBehaviour
{
    bool isRec = false;
    bool doPlay = false;    
    List<float> nums = new List<float>();
    float tempX;
    float tempY;
    //bool playedNoRep = false;
    public Vector3 startPosi;
    public GameObject Player;

    public Transform goalPosition;
    private Vector3 goalStartPosition;

    private Coroutine playingBack;

    public bool freezeActive;
    public bool freezeNow;
    private Vector3 freezePos;
    private GameObject sceneSetter;

    // Start is called before the first frame update    
    void Start()
    {
        freezeActive = false;
        goalStartPosition = new Vector3 (goalPosition.position.x, goalPosition.position.y, goalPosition.position.z);
        sceneSetter = GameObject.Find("EventSystem");
    }
    public void Record () {
        startPosi = transform.position;

        if(playingBack != null){
            StopCoroutine(playingBack);
        }  
        
        isRec = true;
        doPlay = false;

        nums = new List<float>();
        GetComponent<PlayerMovement>().enabled = true;
}
    public void FixedUpdate () {

        // if (playedNoRep == true) {
        //     doPlay = false;
        // }
        if( isRec == true){
            tempX = transform.position.x;
            tempY = transform.position.y;
            nums.Add(tempX);
            nums.Add(tempY);
	    }
        if(doPlay == true){
            doPlay = false;
            playingBack = StartCoroutine("Playback");
	    }   
    }

    public IEnumerator Playback ()
    {
        GetComponent<PlayerMovement>().enabled = false;
        bool hasFrozen = false;
	    for (int i = 0; i < nums.Count; i+=2) {
		    transform.position = new Vector3 (nums[i], nums[i + 1], startPosi.z);

            if(freezeNow){
                freezeNow = false;
                freezePos = gameObject.transform.position;
            }

            if(freezeActive && transform.position == freezePos && !hasFrozen){
                hasFrozen = true;
                yield return new WaitForSeconds(3);
            }

            yield return new WaitForSeconds(0.015f);
        }

        //where to tp to in the end
        int runNumber = sceneSetter.GetComponent<SceneSetter>().runNumber;
        if(gameObject.name.Equals("PlayerGoomba") && (runNumber < 5)){
            transform.position = goalPosition.position;
        }
        else if(gameObject.name.Equals("PlayerGoomba")){

        }
        else if(gameObject.name.Equals("FrowneyGoal") && (runNumber > 6)){

        }
        else{
            transform.position = goalStartPosition;
        }
        

        yield return null;
    }
    public void Freeze(){
        freezeActive = true;
        freezeNow = true;
    }

    public void RunIt () {
        if(playingBack != null){
            StopCoroutine(playingBack);
        }   
        isRec = false;
        doPlay = true;
        //StartCoroutine("Playback");
    }

    public void AppendPos(Transform finalPos){
        // nums.Add(finalPos.position.x);
        // nums.Add(finalPos.position.y);
        // nums.Add(finalPos.position.x);
        // nums.Add(finalPos.position.y);
        // nums.Add(finalPos.position.x);
        // nums.Add(finalPos.position.y);
    }

    public void ResFrez(){
        freezeActive = false;
    }

}   
