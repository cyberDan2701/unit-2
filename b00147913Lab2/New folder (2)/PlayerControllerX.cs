using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //setting my timer to 0.5 sec 
    private float timer = 0.5f;
   
     

    // Update is called once per frame
    void Update()
    {
        // timer is lowered by delta time till at 0 or bellow 
        timer -= Time.deltaTime;
        
        // On spacebar press, send dog if the timer is less then <=0 aswell 
        if (Input.GetKeyDown(KeyCode.Space)&& timer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //reset timer to 0.5 after a dog has spawned 
            timer = 0.5f;
        }
    }
}
