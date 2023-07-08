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

    // Start is called before the first frame update
    void Start()
    {

    }
    public void Record () {
        if (isRec == true) {
            isRec = false;

            Player.GetComponent<Recorder>().StopCoroutine("Playback");
            transform.position = startPosi;
        }
        else if (isRec == false) {
            startPosi = transform.position;

            isRec = true;
            doPlay = false;

            GetComponent<PlayerMovement>().enabled = true;
	    }
    }
    public void Play () {
	    GetComponent<PlayerMovement>().enabled = false;
    }
    public void Update () {

        if (playedNoRep == true) {
            doPlay = false;
        }
        if( isRec == true){
            tempX = transform.position.x;
            tempY = transform.position.y;
            nums.Add(tempX);
            nums.Add(tempY);
            Debug.Log(tempX + "   " + tempY);
	    }
        if(doPlay == true){
            doPlay = false;
            StartCoroutine("Playback");
            //Debug.Log(doPlay);
	    }   

        if(Input.GetKeyDown(KeyCode.R)){
            Debug.Log("Recording");
            Record ();
        }
        if(Input.GetKeyDown(KeyCode.P)){
            RunIt ();
        }

    }   
    public IEnumerator Playback ()
    {
        // Debug.Log("Playback");
        // Debug.Log(Player.transform.position.x + "   " + Player.transform.position.y + "      " + Player.transform.position.z);
         GetComponent<PlayerMovement>().enabled = false;
        // Player.transform.position = new Vector3 (10, 10,0);
	    playedNoRep = true;
	    for (int i = 0; i < nums.Count; i+=2) {
		    transform.position = new Vector3 (nums[i], nums[i + 1], startPosi.z);
            yield return new WaitForSeconds(0.007f);
        }
        yield return null;
    }
    public void Reset () {
        nums.Clear();
        SceneManager.LoadScene("Sample Scene");
    }
    public void RunIt () {
        isRec = false;
        doPlay = true;
        //StartCoroutine("Playback");
    }

}   
