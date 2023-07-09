using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Gun2 : MonoBehaviour
{
    public Transform gun;

    Vector2 direction;

    public GameObject bullet;

    public float bulletSpeed;

    public float maxNumBullets;

    public float fireRate;
    float readyForNextShot;

    public Transform shootPoint;

    List<GameObject> bullets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()    
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)gun.position;
        FaceMouse();

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)){
            if(Time.time > readyForNextShot){
                readyForNextShot = Time.time + 1 / fireRate;
                Shoot();
            }
            
        }

        if(maxNumBullets < bullets.Count){
            RemoveFirst();
        }
    }

    public void RemoveAll(){
        foreach(GameObject b in bullets){
            Destroy(b);
        }
    }

    void FaceMouse(){
        gun.transform.right = direction;
    }   

    void RemoveFirst(){
        GameObject b = bullets.ElementAt(0);
        bullets.RemoveAt(0);
        Destroy(b);
    }

    void Shoot(){
        GameObject bulletInst = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        bulletInst.GetComponent<Rigidbody2D>().AddForce(bulletInst.transform.right * bulletSpeed);
        bullets.Add(bulletInst);
    }
}
