using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject camPoint;
    public GameObject currentRoom;
    public GameObject formerRoom;
    public GameObject player;


    private void Start()
    {
     //   player.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Camera.main.transform.position = camPoint.transform.position;
            currentRoom.SetActive(true);
            //player.transform.position = Vector2(currentlocation + 1, 0);
            formerRoom.SetActive(false);
        }
    }
}
