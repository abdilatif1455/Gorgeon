using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraswitch : MonoBehaviour
{
    //List ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //    transform.position om playern går in i en anan zone så laddas allt i den zonen + byter till en annan camera point.
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //enter transition zone switch add +1 to campoint then check if the corect number is there. if not -2 to campoint
        // or make all doors oneway tickets to the other room.
    }
}
