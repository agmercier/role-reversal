using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public GameObject gun;

    Vector2 direction;

    // Start is called before the first frame update
    void Start()    
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //direction = mousePos - Gun.transform.position;
        FaceMouse();
    }

    void FaceMouse(){
        //Gun.transform.right = direction;
    }   
}
