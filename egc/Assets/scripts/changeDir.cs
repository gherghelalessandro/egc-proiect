using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDir : MonoBehaviour
{
    public Omovement move;
    public float x, y, z;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="changer"||other.gameObject.tag=="platform")
        {
            move = other.GetComponent<Omovement>();
            move.x = x;
            move.y = y;
            move.z = z;
        }
    }

}
