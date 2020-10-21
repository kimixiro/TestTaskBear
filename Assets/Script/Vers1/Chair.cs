using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public bool booked;
    public Vector3 pos;
    
    void Start()
    {
        booked = false;
        pos = transform.position;
    }
    
}
