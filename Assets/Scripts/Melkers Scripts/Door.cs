using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] 
    public Transform destination;

    public Transform GetDestination ()
    {
        return destination;
    }

}
