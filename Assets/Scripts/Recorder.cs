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
    bool playedNoRep = false;
    public Vector3 startPosi;
    public GameObject Player;
    public Transform goalPosition;
    private Coroutine playingBack;

    // Start is called before the first frame update
    void Start()
    {

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

        if (playedNoRep == true) {
            doPlay = false;
        }
        if( isRec == true){
            tempX = transform.position.x;
            tempY = transform.position.y;
            nums.Add(tempX);
            nums.Add(tempY);
	    }
        if(doPlay == true){
            doPlay = false;
            playingBack = StartCoroutine("Playback");
            //Debug.Log(doPlay);
	    }   
    }

    public IEnumerator Playback ()
    {
        GetComponent<PlayerMovement>().enabled = false;
	    for (int i = 0; i < nums.Count; i+=2) {
		    transform.position = new Vector3 (nums[i], nums[i + 1], startPosi.z);
            yield return new WaitForSeconds(0.015f);
        }
        if(!gameObject.name.Equals("PlayerGoomba")){
            transform.position = goalPosition.position;
        }
        
        yield return null;
    }
    public void Reset () {
        nums.Clear();
        SceneManager.LoadScene("Sample Scene");
    }
    public void RunIt () {
        if(playingBack != null){
            StopCoroutine(playingBack);
        }   
        isRec = false;
        doPlay = true;
        //StartCoroutine("Playback");
    }

}   
