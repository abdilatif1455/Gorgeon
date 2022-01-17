using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendelum : MonoBehaviour
{
    Rigidbody2D rb2d;//Reference till rigidbody

    public float moveSpeed;
    public float leftAngle; //Vinkel f�r v�nstra sidan
    public float rightAngle; //Vinkel f�r h�gra sidan

    bool movingClockwise;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); //L�nkar den f�rsta rigidbodyn p� objekten (Hand i Hierarchy)
        movingClockwise = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.rotation.z);
        Move();
    }

    public void ChangeMoveDir ()
    {
        if (transform.rotation.z > rightAngle)// Om pendelum hamnar bakom rightAngle s� kommer den att �ka �t v�nster
        {
            movingClockwise = false;
        }
        if (transform.rotation.z < leftAngle)// Om pendelum hamnar bakom leftAngle s� kommer den att �ka �t h�ger
        {
            movingClockwise = true;
        }
    }

    public void Move()
    {
        ChangeMoveDir();

        if (movingClockwise)
        {
            rb2d.angularVelocity = moveSpeed; //R�r sig �t h�ger
        }

        if (!movingClockwise)
        {
            rb2d.angularVelocity = -1*moveSpeed; //R�r sig �t v�nster
        }
    }

}
