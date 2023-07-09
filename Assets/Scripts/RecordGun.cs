using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RecordGun : MonoBehaviour
{   
    bool isRec = false;
    bool doPlay = false;
    private Coroutine playingBack;
    private GameObject sceneSetter;
    List<Quaternion> rotations = new List<Quaternion>();

    List<float> shotTimes = new List<float>();
    private float startRecShoot;
    private float startPlayShoot;

    // Start is called before the first frame update
    void Start()
    {
        sceneSetter = GameObject.Find("EventSystem");
    }

    // Update is called once per frame
    void Update()
    {
         if( isRec == true && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))){
            shotTimes.Add(Time.time - startRecShoot);
	    }
    }

    public void Record () {
        if(playingBack != null){
            StopCoroutine(playingBack);
        }  
        
        isRec = true;
        doPlay = false;

        rotations = new List<Quaternion>();
        shotTimes = new List<float>();

        startRecShoot = Time.time;
    }
    public void FixedUpdate () {

        // if (playedNoRep == true) {
        //     doPlay = false;
        // }
        if( isRec == true){
            rotations.Add(gameObject.transform.rotation);
	    }

        if(doPlay == true){
            doPlay = false;
            playingBack = StartCoroutine("Playback");
	    }   
    }

    public IEnumerator Playback ()
    {
        startPlayShoot = Time.time;
        int j = 0;
	    for (int i = 0; i < rotations.Count; i+=1) {
		    transform.rotation = rotations.ElementAt(i);
            
            if(shotTimes.ElementAt(j) < (Time.time - startPlayShoot)){
                gameObject.GetComponent<Gun2>().Shoot();
                j++;
            }

            yield return new WaitForSeconds(0.015f);
        }
        //where to tp to in the end
        int runNumber = sceneSetter.GetComponent<SceneSetter>().runNumber;
        yield return null;
    }

    public void RunIt () {
        if(playingBack != null){
            StopCoroutine(playingBack);
        }   
        isRec = false;
        doPlay = true;
    }
}
