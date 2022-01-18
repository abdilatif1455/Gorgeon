using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true; //Jag ber�ttar vad enemyn ska g�ra n�r den kommer till kanten av en platform

    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //Nu kommer den att g� �t h�ger

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance); //(origin, direction, lenght)
        if (groundInfo.collider == false) //Kollar om Raycasten kolliderar med n�got
        {
            if (movingRight == true) //Om vi gick �t h�ger, s� kommer enemyn att v�nda sig med 180 grader
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else //Om vi gick �t v�nster, s� kommer enemyn att f� sin vanliga rotation (0, 0, 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

    public void ShootAngle ()
    {

    }

}
